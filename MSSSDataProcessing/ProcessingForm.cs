using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galileo;

namespace MSSSDataProcessing
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
            
        }
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();



        #region Global Methods

        private void LoadData()
        {
            ReadData satellite = new ReadData();
            sensorA.Clear();
            sensorB.Clear();
            Trace.TraceInformation("Loading data to listView");
            for (int i = 0; i < 400; i++)
            {
                sensorA.AddFirst(satellite.SensorA((double)numWheelMean.Value, (double)numWheelSigma.Value));
                sensorB.AddFirst(satellite.SensorB((double)numWheelMean.Value, (double)numWheelSigma.Value));
                Trace.WriteLine("Adding to LinkedLists \t| sensorA: " + sensorA.First.Value + "\t| sensorB: " + sensorB.First.Value.ToString());
            }
            Trace.TraceInformation("Data loaded to listView.\n");
        }

        private void ShowAllSensorData()
        {
            listViewDisplay.Items.Clear();
            Trace.TraceInformation("Displaying Sensor A & B in ListView");
            LinkedList<double>.Enumerator sensorAEnum = sensorA.GetEnumerator();
            LinkedList<double>.Enumerator sensorBEnum = sensorB.GetEnumerator();
            while (sensorBEnum.MoveNext() && sensorAEnum.MoveNext())
            {
                ListViewItem row = new ListViewItem(sensorAEnum.Current.ToString());
                row.SubItems.Add(sensorBEnum.Current.ToString());
                listViewDisplay.Items.Add(row);
                Trace.WriteLine("Adding to ListView SensorA: " + sensorAEnum.Current.ToString() + "\t| SensorB: " + sensorBEnum.Current.ToString());
            }
            Trace.TraceInformation("List view populated.\n");

        }

        #endregion

        #region Utility Methods
        // Checks file dir and incrememnts upwards for each existing demo file until a new file number is reached.
        public string checkFileDir(string fileName)
        {
            int fileCount = 0;
            string fileNameExt = fileName + fileCount.ToString("_00") + ".log";
            while (true)
            {
                if (File.Exists(fileNameExt))
                {
                    fileCount++;
                    fileName = Path.GetFileName(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName
                                + String.Format(fileCount.ToString("_00")) + ".log"));
                    Trace.TraceInformation("File Exists - File count: " + fileCount);
                    break;
                }
                else
                {
                    fileName = fileName + "_00.log";
                    break;
                }
            }
            Trace.TraceInformation("New file " + fileName + " created.\n");
            return fileName;
        }

        private int NumberOfNodes(LinkedList<double> sensor)
        {
            return sensor.Count;
        }
        private void PopulateListBox(LinkedList<double> sensor, ListBox listBox)
        {
            listBox.Items.Clear();
            var sensorEnum = sensor.GetEnumerator();
            while (sensorEnum.MoveNext())
            {
                listBox.Items.Add(sensorEnum.Current);
            }
        }
        private int RadioButtonIndex(string radioGrpName)
        {
            // If you choose to have value 1 as default, consider removing current else and else if condition to
            // clean up code.
            int index = 1;
            switch (radioGrpName.ToUpper())
            {
                case "SORTA":
                    if (radioSelectionA.Checked) { index = 1; break; }  // Selection Sort is selected.
                    else { index = 0; break; }                          // Insertion Sort is selected.

                case "SEARCHA":
                    if (radioIterativeA.Checked) { index = 1; break; }  // Iterative Search is selected.
                    else { index = 0; break; }                          // Recursive Search is selected.

                case "SORTB":
                    if (radioSelectionB.Checked) { index = 1; break; }  // Selection Sort is selected.
                    else { index = 0; break; }                          // Insertion Sort is selected.

                case "SEARCHB":
                    if (radioIterativeB.Checked) { index = 1; break; }  // Iterative Search is selected.
                    else { index = 0; break; }                          // Recursive Search is selected.

            }
            return index;
        }
        private bool CheckInput(string TbInput, TextBox TbTarget)
        {
            if (string.IsNullOrEmpty(TbInput))
            {   // Empty text box input.
                TbTarget.Focus();
                toolTip.Show("Please enter an appropriate integer or decimal value", TbTarget, 60, 15, 3000);
                statusLabel.Text = "Check input!";
                return false;
            }
            else
                return true;

        }

        // First int is mid index, second int is the range of values to be checked.
        // Third int is the approximate value range difference.
        private void DisplayListBoxData(ListBox listBox, int index, int range, double valueRange)
        {
            try
            {
               
                listBox.SelectedItems.Clear();
                int pointerIndex = index - range / 2;   // pointerIndex variable holds index of first item in the range of values to be checked.
                if (pointerIndex < 0)                   // If the search index = 1, range = 6, the starting pointerIndex value will be 0.
                {                                       // range will be reduced by (1 - 3) = -2. Range = 4. 4 values will then be iterated through & checked.
                    range += pointerIndex;  // New range set
                    pointerIndex = 0;       // Sets starting point to 0, range is reduced to compensate for non-existent negative indexes. e.g -3, -2, -1
                }
                double low, high, current;  // Boundaries for listBox value selection.
                low = double.Parse(listBox.Items[index].ToString()) - valueRange;
                high = double.Parse(listBox.Items[index].ToString()) + valueRange;
                Trace.TraceInformation("Selection Display\t| Total selection range: " + range + "\t|Deviation range from target: " + valueRange);
                // pointerIndex value is incremented untill i >= range. Within the loop, if statement current value.
                for (int i = 0; i < range && pointerIndex < 400; i++)
                { 
                    current = double.Parse(listBox.Items[pointerIndex].ToString());
                    Trace.WriteLine("Comparing Target: " + current + " - High: " + high + "\t| Low:" + low + " \t| Deviation range from target: " + valueRange);
                    if (current > low && current < high)    // If current value is within upper and lower bounds.
                    {
                        listBox.SetSelected(pointerIndex, true);    // Specified index is set as selected within listBox.
                        Trace.TraceInformation(current + " is within bounds. Now selected in " + listBox.Name);
                    }
                    pointerIndex++;
                }
                Trace.TraceInformation("listBox target selection complete.\n");
            }
            catch (IndexOutOfRangeException)
            {
                Trace.TraceError("Index is out of bounds within the array.\n");
            }
        }

        private double IntOrDouble(string TbInput)
        {
            bool isInt = int.TryParse(TbInput, out int result);
            double searchValue;
            if (!isInt)
                searchValue = double.Parse(TbInput);
            else
                searchValue = result;
            return searchValue;
        }


        #endregion

        #region Sort & Search Methods
        
        private bool SelectionSort(LinkedList<double> sensor)
        {
            int min;
            int max = NumberOfNodes(sensor);
            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (sensor.ElementAt(min) < sensor.ElementAt(j))    // If sensor to the left is less than sensor element on the right, raise the minimum value to the right.
                        min = j;                                        // else continue iterating
                }
                LinkedListNode<double> currentMin = sensor.Find(sensor.ElementAt(min));
                LinkedListNode<double> currentI = sensor.Find(sensor.ElementAt(i));
                Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current pointer Value " + currentI.Value);
                double temp = currentMin.Value;
                currentMin.Value = currentI.Value;      // Swaps the found minimum with the I current pointer value as the minimum is currently the lowest value in the list.
                currentI.Value = temp;                  // Minimum values are shuffled down using selection sort.
            }
            return true;
        }

        private bool InsertionSort(LinkedList<double> sensor)
        {
            int max = NumberOfNodes(sensor);
            for (int i = 0; i < max - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (sensor.ElementAt(j - 1) < sensor.ElementAt(j))
                    {
                        LinkedListNode<double> current = sensor.Find(sensor.ElementAt(j));
                        LinkedListNode<double> currentLeft = sensor.Find(sensor.ElementAt(j - 1));
                        double temp = current.Value;
                        current.Value = currentLeft.Value;
                        currentLeft.Value = temp;
                    }
                }
            }
            return true;
        }

        private int BinarySearchIterative(LinkedList<double> sensor, double searchValue)
        {
            int min = 0;
            int max = NumberOfNodes(sensor);
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                // Find an exact value or if searchValue is an int, it can be matched with a casted int for a more general search.
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid)) // 
                {
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue < sensor.ElementAt(mid))
                {
                    min = mid + 1;
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Increasing min to mid + 1:" + min);
                }
                else
                {
                    max = mid - 1;
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Decreasing max to mid - 1:" + max);
                }
                /*
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))
                    return mid;
                else if (searchValue < sensor.ElementAt(mid))
                    min = mid + 1;
                else
                    max = mid - 1;
                */
            }
            return min;
        }

        private int BinarySearchRecursive(LinkedList<double> sensor, double searchValue, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))
                {
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue > sensor.ElementAt(mid))
                {
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Decreasing max - 1:" + (mid - 1));
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                }
                else
                {
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Increasing min + 1:" + (mid + 1));
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                }
                /*
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))  // Checks if searchValue equals double at mid index.
                  return mid;                                              // Casting sensor element to int allows for
                else if (searchValue > sensor.ElementAt(mid))               // integers entered for a general search. 
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                else
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                */
            }
            return min;
        }

        #endregion

        #region UI Button Methods

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
            PopulateListBox(sensorA, listBoxA);
            PopulateListBox(sensorB, listBoxB);
        }

        bool sortedA = false;
        private void buttonSortA_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            int sortNum = RadioButtonIndex("SortA");
            if (sortNum == 1)
            {
                Trace.TraceInformation("Starting stopwatch   | Sort: Selection");
                sw.Start();
                sortedA = SelectionSort(sensorA);   // Sets bool to true upon sort success. Enables search function.
                sw.Stop();
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                TbSortSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorA, listBoxA);
                statusLabel.Text = "Sensor A has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                Trace.TraceInformation("Starting stopwatch   | Sort: Insertion");
                sw.Start();
                sortedA = InsertionSort(sensorA);
                sw.Stop();
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                TbSortSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorA, listBoxA);
                statusLabel.Text = "Sensor A has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool sortedB = false;
        private void buttonSortB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            int sortNum = RadioButtonIndex("SortB");
            if (sortNum == 1)
            {
                Trace.TraceInformation("Starting stopwatch   | Sort: Selection");
                sw.Start();
                sortedB = SelectionSort(sensorB);   // Sets bool to true upon sort success. Enables search function.
                sw.Stop();
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                TbSortSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorB, listBoxB);
                statusLabel.Text = "Sensor B has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                Trace.TraceInformation("Starting stopwatch   | Sort: Insertion");
                sw.Start();
                sortedB = InsertionSort(sensorB);
                sw.Stop();
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                TbSortSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorB, listBoxB);
                statusLabel.Text = "Sensor B has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonSearchA_Click(object sender, EventArgs e)
        {
            
            if (CheckInput(TbTargetA.Text, TbTargetA) && sortedA)
            {
                Stopwatch sw = new Stopwatch();
                double searchValue = IntOrDouble(TbTargetA.Text);
                int searchNum = RadioButtonIndex("SearchA");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                    sw.Start();                                                     // Beginning of stopwatch timer.
                    int foundIndex = BinarySearchIterative(sensorA, searchValue);   
                    sw.Stop();                                                      // End of stopwatch timer.
                    TbSearchSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();    // Total time in ms displayed to textBox.
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");                                               // I put the trace line underneath in this method because it looks neat.
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorA.ElementAt(foundIndex) + "\t| Searching using Iterative Binary Search"; 
                    DisplayListBoxData(listBoxA, foundIndex, (int)numWheelSelRangeA.Value, (double)numWheelTarRangeA.Value); // Added input from controls
                }                                   // First int is mid index, second int is the range of values to be checked.Third int is the value range deviation.
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Recursive");
                    sw.Start();
                    int foundIndex = BinarySearchRecursive(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    TbSearchSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorA.ElementAt(foundIndex) + "\t| Searching using Recursive Binary Search";
                    DisplayListBoxData(listBoxA, foundIndex, (int)numWheelSelRangeA.Value, (double)numWheelTarRangeA.Value);
                }
                else 
                    toolTip.Show("Select a search algorithm", radioIterativeA, 65, 20, 3000);
            }
            else if(!sortedA)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortA, 45, 15, 3000);
                statusLabel.Text = "Sensor A values not sorted. Cannot search";
            }

        }
        private void buttonSearchB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            if (CheckInput(TbTargetB.Text, TbTargetB) && sortedB)
            {
                double searchValue = IntOrDouble(TbTargetB.Text);
                int searchNum = RadioButtonIndex("SearchB");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                    sw.Start();
                    int foundIndex = BinarySearchIterative(sensorB, searchValue);
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "\t| Searching using Iterative Binary Search";
                    TbSearchSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    DisplayListBoxData(listBoxB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelTarRangeB.Value);
                }
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Recursive");
                    sw.Start();
                    int foundIndex = BinarySearchRecursive(sensorB, searchValue, 0, NumberOfNodes(sensorB));
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "\t| Searching using Recursive Binary Search";
                    TbSearchSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    DisplayListBoxData(listBoxB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelTarRangeB.Value);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeB, 65, 20, 3000);
            }
            else if (!sortedB)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortB, 45, 15, 3000);
                statusLabel.Text = "Sensor B values not sorted. Cannot search";
                Trace.TraceInformation("SensorB attempted to search but its not sorted!?!?");
            }
        }
        private void TbTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void TbTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        #endregion

        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            Trace.Listeners.Clear();
            Trace.Listeners.Add(new TextWriterTraceListener(checkFileDir("TraceOutput"), "myListener"));
        }

        private void ProcessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trace.Flush();
        }
    }
}

