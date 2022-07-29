using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Galileo;

namespace MSSSDataProcessing
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
            
        }
        // 4.1 Create two data structures using the LinkedList<T>, The data must be of type “double”,  
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();

        #region Global Methods

        // 4.2 Create a method called “LoadData” which will populate both LinkedLists.
        private void LoadData()
        {
            ReadData satellite = new ReadData();
            sensorA.Clear();
            //sensorA = new LinkedList<double>();
            //sensorB = new LinkedList<double>();
            sensorB.Clear();
            Trace.TraceInformation("Loading data to LinkedLists");
            for (int i = 0; i < 400; i++)
            {
                sensorA.AddFirst(satellite.SensorA((double)numWheelMean.Value, (double)numWheelSigma.Value));
                sensorB.AddFirst(satellite.SensorB((double)numWheelMean.Value, (double)numWheelSigma.Value));
                //Trace.WriteLine("Loading to LinkedLists \t| sensorA: " + sensorA.First.Value + "\t| sensorB: " + sensorB.First.Value.ToString());
            }
            Trace.TraceInformation("Data loaded to LinkedLists.\n");
            
        }
        // 4.3	Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView.
        private void ShowAllSensorData()
        {
            listViewDisplay.Items.Clear();
            Trace.TraceInformation("Displaying Sensor A & B in ListView");
            int max = NumberOfNodes(sensorA);
            for (int i = 0; i < max; i++) 
            {
                ListViewItem row = new ListViewItem(sensorA.ElementAt(i).ToString());
                row.SubItems.Add(sensorB.ElementAt(i).ToString());
                listViewDisplay.Items.Add(row);
                //Trace.WriteLine("Displaying to ListView \t|SensorA: " + sensorAEnum.Current.ToString() + "\t| SensorB: " + sensorBEnum.Current.ToString());
            }
            Trace.TraceInformation("List view populated.\n");
        }

        #endregion

        #region Utility Methods

        // 4.6	Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the appropriate ListBox
        private void DisplayListBoxData(LinkedList<double> sensor, ListBox listBox)
        {
            Trace.TraceInformation("Displaying list  in listBox");
            listBox.Items.Clear();
            foreach (double data in sensor)
            {
                listBox.Items.Add(data);
            }
            Trace.TraceInformation("Display list complete.\n");
        }
        // 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList.
        private int NumberOfNodes(LinkedList<double> sensor)
        {
            return sensor.Count;
        }
        private void HighlightData(ListBox listBox, int index, int range, double valueRange)
        {
            try
            {
                listBox.SelectedItems.Clear();
                double low, high, current;                                          // Boundaries for value selection.
                low = (double)listBox.Items[index] - valueRange;                    // Low value set
                high = (double)listBox.Items[index] + valueRange;                   // High value set
                Trace.TraceInformation("Selection configuration\nTotal selection range: " + range + "\t| Value Deviation range: " + valueRange);

                int pointerIndex = index - (range / 2);     // Pointer index value is the first value to be checked.
                if (pointerIndex < 0)                       // If pointing before first list value, set pointer to first list value.
                    pointerIndex = 0;
                for (int i = pointerIndex; i <= index + (range / 2) && i < 400; i++)    // i is set to the floor index of range. 
                {
                    current = (double)listBox.Items[i];                // Current value to be compared.
                    //Trace.WriteLine("Target: " + current + " - High: " + high + "\t| Low:" + low + " \t| Value Deviation range: " + valueRange);
                    if (current > low && current < high)    // If current value is within upper and lower bounds.
                    {
                        listBox.SetSelected(i, true);       // Specified index is set as selected within listBox.
                        //Trace.WriteLine("## " + current + " is within bounds. \t| Now selected in " + listBox.Name + " ##\n");
                    }
                }
                Trace.TraceInformation("listBox target selection complete.\n");
            }
            catch (IndexOutOfRangeException)
            {
                Trace.TraceError("Index is out of bounds within the array.\n");
            }
        }

        #region DataChecking
        // Checks file dir and incrememnts upwards for each existing demo file until a new file number is reached.
        public string CheckFileDir(string fileName)
        {
            int fileCount = 0;
            string fileNameExt = fileName + fileCount.ToString("_00") + ".log";     // We fuze the file name, file number increment and file extension here.
            while (true)
            {
                if (File.Exists(fileNameExt))       // Checks if the file name already exists.
                {
                    fileCount++;
                    fileNameExt = Path.GetFileName(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName
                                + String.Format(fileCount.ToString("_00")) + ".log"));
                    Trace.TraceInformation("File Exists - File count: " + fileCount);
                }
                else
                    break; // If the file name doesn't exist break out of the loop. It's our new filename.
            }
            fileName = fileNameExt;
            return fileName;
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
        private bool CheckInput(string TbInput, TextBox TbTarget, LinkedList<double> sensor)
        {
            try
            {
                Trace.TraceInformation("Checking input " + TbInput);
                if (string.IsNullOrEmpty(TbInput))
                {   // Empty text box input.
                    TbTarget.Focus();
                    toolTip.Show("Check input!", TbTarget, 60, 15, 3000);
                    statusLabel.Text = "Please enter an appropriate integer or decimal value";
                    Trace.TraceWarning("Input box is empty.\n");
                    return false;
                }
                else if (double.Parse(TbInput) < (int)sensor.First.Value || double.Parse(TbInput) > sensor.Last.Value)   // Parsing as in to increase search to whole numbers.
                {   // Input is out of range
                    TbTarget.Focus();
                    toolTip.Show("Input is out of bounds!", TbTarget, 60, 15, 3000);
                    statusLabel.Text = "Please enter an appropriate value between " + sensor.First.Value + " and " + sensor.Last.Value;
                    TbTarget.Clear();
                    Trace.WriteLine(sensor.First.Value + " > " + TbInput + " & " + TbInput + " < " + sensor.Last.Value);
                    Trace.TraceWarning("Value is out of bounds.\n");
                    return false;
                }
                else
                    return true;
            }
            catch
            {
                statusLabel.Text = "Error finding value, list may be empty.";
                return false;
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
        private LinkedList<int> TotalOccurrences(LinkedList<double> sensor)
        {
            LinkedList<int> result = new LinkedList<int>();
            if (IsSorted(sensor))
            {
                foreach (var data in sensor)
                {
                    //int occurrences = sensor.Count(x => (x + 0.5) < data && data > (x - 0.5));
                    int occurrences = sensor.Count(x => IsWithin(x, data - (double)numWheelDistribution.Value, data + (double)numWheelDistribution.Value));
                    result.AddLast(occurrences);
                }
            }
            else
                statusLabel.Text = "Sensor must be SORTED.";
            return result;
        }
        private bool IsWithin(double value, double min, double max)
        {
            return value >= min && value <= max;
        }
        private bool IsSorted(LinkedList<double> sensor)
        {
            int count = NumberOfNodes(sensor) - 1;
            for (int i = count; i > 0; i--)
            {
                if (sensor.ElementAt(i) < sensor.ElementAt(i - 1))
                    return false;
            }
            return true;
        }
            #endregion
        #endregion

        #region Sort & Search Methods
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while the calling code argument is the linkedlist name. 
        private bool SelectionSort(LinkedList<double> sensor)
        {
            int min;
            int max = NumberOfNodes(sensor);
            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (sensor.ElementAt(min) > sensor.ElementAt(j))    // If sensor to the left is less than sensor element on the right, raise the minimum value to the right.
                        min = j;                                        // else continue iterating
                }
                LinkedListNode<double> currentMin = sensor.Find(sensor.ElementAt(min));
                LinkedListNode<double> currentI = sensor.Find(sensor.ElementAt(i));
                //Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current pointer Value " + currentI.Value + "\t| " + currentMin.Value + " > " + currentI.Value + " swapping.");
                double temp = currentMin.Value;
                currentMin.Value = currentI.Value;      // Swaps the found minimum with the I current pointer value as the minimum is currently the lowest value in the list.
                currentI.Value = temp;                  // Minimum values are shuffled down using selection sort.
            }
            return true;
        }
        // 4.8	Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the calling code argument is the linkedlist name. 
        private bool InsertionSort(LinkedList<double> sensor)
        {
            int max = NumberOfNodes(sensor);
            for (int i = 0; i < max - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (sensor.ElementAt(j - 1) > sensor.ElementAt(j))
                    {
                        LinkedListNode<double> current = sensor.Find(sensor.ElementAt(j));
                        LinkedListNode<double> currentLeft = current.Previous;
                        //Trace.WriteLine("Left Value: " + currentLeft.Value + " | Current Value: " + current.Value + "\t| " + currentLeft.Value + " > " + current.Value + " swapping.");
                        double temp = current.Value;
                        current.Value = currentLeft.Value;
                        currentLeft.Value = temp;
                    }
                    //else
                        //Trace.WriteLine(sensor.ElementAt(j - 1) + " < " + sensor.ElementAt(j));
                }
            }
           return true;
        }
        // 4.9	Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum.
        private int BinarySearchIterative(LinkedList<double> sensor, double searchValue)
        {
            int min = 0;
            int max = NumberOfNodes(sensor);
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                // Find an exact value or if searchValue is an int, it can be matched with a casted int for a more general search.
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))
                    return mid;
                else if (searchValue > sensor.ElementAt(mid))
                    min = mid + 1;
                else
                    max = mid - 1;
                /**
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid)) // 
                {
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue > sensor.ElementAt(mid))
                {
                    min = mid + 1;
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Increasing min to mid + 1: " + min + "\t| Shifting search range to right.");
                }
                else
                {
                    max = mid - 1;
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Decreasing max to mid - 1: " + max + "\t| Shifting search range to left.");
                }
                */
            }
            return min;
        }
        // 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum. 
        private int BinarySearchRecursive(LinkedList<double> sensor, double searchValue, int min, int max)
        {
            int mid;
            while (min <= max - 1)
            {
                mid = (min + max) / 2;
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))  // Checks if searchValue equals double at mid index.
                    return mid;                                              // Casting sensor element to int allows for
                else if (searchValue < sensor.ElementAt(mid))               // integers entered for a general search. 
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                else
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                /**
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))
                {
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue < sensor.ElementAt(mid))
                {
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Decreasing max: " + (mid - 1) + "\t| Shifting search range to left.");
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                }
                else
                {
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Increasing min: " + (mid + 1) + "\t| Shifting search range to right.");
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                }
                */
            }
            return min;
        }

        #region MiscSort
        private void InsertionSortAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox)
        {
            try
            {
                Thread.Sleep(10);
                Trace.TraceInformation("Starting stopwatch   | Sort: Insertion");
                Stopwatch sw = Stopwatch.StartNew();
                InsertionSort(list);
                sw.Stop();
                textBox.Text = sw.ElapsedMilliseconds.ToString() + " ms";
                DisplayListBoxData(list, listBox);
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
            }
            catch(Exception ex)
            {
                statusLabel.Text = "Error during Insertion Sort";
                Trace.TraceError(ex.Message);
                MessageBox.Show(ex.Message, "Insertion Sort");
            }
        }
        private void SelectionSortAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox)
        {
            try
            {
                Thread.Sleep(10);
                Trace.TraceInformation("Starting stopwatch   | Sort: Selection");
                Stopwatch sw = Stopwatch.StartNew();
                SelectionSort(list);
                sw.Stop();
                textBox.Text = sw.ElapsedMilliseconds.ToString() + " ms";
                DisplayListBoxData(list, listBox);
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error during Selection Sort";
                Trace.TraceError(ex.Message);
                MessageBox.Show(ex.Message, "Selection Sort");
            }

        }
        #endregion

        #endregion

        #region UI Button Methods

    #region TAB Main
        // 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.The input parameters are empty, and the return type is void.
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxSensorA);
            DisplayListBoxData(sensorB, listBoxSensorB);

        }
        private void buttonSortA_Click(object sender, EventArgs e)
        {
            int sortNum = RadioButtonIndex("SortA");
            if (sortNum == 1)
            {
                SelectionSortAndDisplay(listBoxSensorA, sensorA, textBoxSortSpdA);
                ShowAllSensorData();
                //DisplayListBoxData(sensorA, listBoxSensorA);
                statusLabel.Text = "Sensor A has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                InsertionSortAndDisplay(listBoxSensorA, sensorA, textBoxSortSpdA);
                ShowAllSensorData();
                //DisplayListBoxData(sensorA, listBoxSensorA);
                statusLabel.Text = "Sensor A has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonSortB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            int sortNum = RadioButtonIndex("SortB");
            if (sortNum == 1)
            {
                /**
                Trace.TraceInformation("Selection Sort Sensor B", "Starting stopwatch   | Sort: Selection");
                sw.Start();
                SelectionSort(sensorB);   // Sets bool to true upon sort success. Enables search function.
                sw.Stop();
                Trace.TraceInformation("Selection Sort Sensor B", "Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                textBoxSortSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString() + " ms";
                */
                SelectionSortAndDisplay(listBoxSensorB, sensorB, textBoxSortSpdB);
                ShowAllSensorData();
                //DisplayListBoxData(sensorB, listBoxSensorB);
                statusLabel.Text = "Sensor B has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                /**
                Trace.TraceInformation("Insertion Sort Sensor B", "Starting stopwatch   | Sort: Insertion");
                sw.Start();
                InsertionSort(sensorB);
                sw.Stop();
                Trace.TraceInformation("Insertion Sort Sensor B", "Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                textBoxSortSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString() + " ms";
                */
                InsertionSortAndDisplay(listBoxSensorB, sensorB, textBoxSortSpdB);
                ShowAllSensorData();
                statusLabel.Text = "Sensor B has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 4.11	Create button click methods that will search the LinkedList for a value entered into a textbox on the form.
        private void buttonSearchA_Click(object sender, EventArgs e)
        {
            bool sorted = IsSorted(sensorA);
            if (sorted && CheckInput(textBoxTargetA.Text, textBoxTargetA, sensorA))
            {
                Stopwatch sw = new Stopwatch();
                double searchValue = IntOrDouble(textBoxTargetA.Text);
                int searchNum = RadioButtonIndex("SearchA");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                    sw.Start();                                                     // Beginning of stopwatch timer.
                    int foundIndex = BinarySearchIterative(sensorA, searchValue);
                    sw.Stop();                                                      // End of stopwatch timer.
                    textBoxSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";                 // Total time in ms displayed to textBox.
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");                                               // I put the trace line underneath in this method because it looks neat.
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorA.ElementAt(foundIndex) + "  | Searching using Iterative Binary Search";
                    HighlightData(listBoxSensorA, foundIndex, (int)numWheelSelRangeA.Value, (double)numWheelValueRangeA.Value); // Added input from controls
                }                                   // First int is mid index, second int is the range of values to be checked.Third int is the value range deviation.
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Recursive");
                    sw.Start();
                    int foundIndex = BinarySearchRecursive(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    textBoxSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorA.ElementAt(foundIndex) + "  | Searching using Recursive Binary Search";
                    HighlightData(listBoxSensorA, foundIndex, (int)numWheelSelRangeA.Value, (double)numWheelValueRangeA.Value);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeA, 65, 20, 3000);
            }
            else if (!sorted)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortA, 45, 15, 3000);
                statusLabel.Text = "Sensor A values not sorted. Cannot search";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        // 4.11
        private void buttonSearchB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            bool sorted = IsSorted(sensorB);
            if (sorted && CheckInput(textBoxTargetB.Text, textBoxTargetB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetB.Text);
                int searchNum = RadioButtonIndex("SearchB");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Iterative Search Sensor B", "Starting stopwatch   | Binary Search: Iterative");
                    sw.Start();
                    int foundIndex = BinarySearchIterative(sensorB, searchValue);
                    sw.Stop();
                    Trace.TraceInformation("Iterative Search Sensor B", "Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "  | Searching using Iterative Binary Search";
                    textBoxSearchSpdB.Text = sw.ElapsedTicks.ToString() + " Ticks";
                    HighlightData(listBoxSensorB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelValueRangeB.Value);
                }
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Recursive Search Sensor B", "Starting stopwatch   | Binary Search: Recursive");
                    sw.Start();
                    int foundIndex = BinarySearchRecursive(sensorB, searchValue, 0, NumberOfNodes(sensorB));
                    sw.Stop();
                    Trace.TraceInformation("Recursive Search Sensor B", "Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "  | Searching using Recursive Binary Search";
                    textBoxSearchSpdB.Text = sw.ElapsedTicks.ToString() + " Ticks";
                    HighlightData(listBoxSensorB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelValueRangeB.Value);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeB, 65, 20, 3000);
            }
            else if (!sorted)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortB, 45, 15, 3000);
                statusLabel.Text = "Sensor B values not sorted. Cannot search";
                Trace.TraceWarning("SensorB attempted to search but its not sorted!?!?");
            }
        }
        private void textBoxTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric Input ONLY", textBoxTargetA, 45, 15, 3000);

        }
        private void textBoxTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric Input ONLY", textBoxTargetB, 45, 15, 3000);
        }


    #endregion

    #region TAB Processing
        private void buttonLoadProcessing_Click(object sender, EventArgs e)
        {
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorProcessingA);
            DisplayListBoxData(sensorB, listBoxSensorProcessingB);
        }
        private void buttonSortProcessingA_Click(object sender, EventArgs e)
        {

            LinkedList<double> clone = sensorA;
            /*
            Stopwatch sw = Stopwatch.StartNew();
            SelectionSort(sensorA);
            sw.Stop();
            textBoxSelectionSortSpdA.Text = sw.ElapsedMilliseconds.ToString() + " ms";
            sw = Stopwatch.StartNew();
            InsertionSort(clone);
            sw.Stop();
            textBoxInsertionSortSpdA.Text = sw.ElapsedMilliseconds.ToString() + " ms";
            DisplayListBoxData(sensorA, listBoxSensorProcessingA);
            */
            SelectionSortAndDisplay(listBoxSensorProcessingA, sensorA, textBoxSelectionSortProcessingA);
            InsertionSortAndDisplay(listBoxSensorProcessingA, clone, textBoxInsertionSortProcessingA);
            //UpdateAllListBoxes();
        }
        private void buttonSortProcessingB_Click(object sender, EventArgs e)
        {
            LinkedList<double> clone = sensorB;
            /*
            Stopwatch sw = Stopwatch.StartNew();
            SelectionSort(sensorB);
            sw.Stop();
            textBoxSelectionSortProcessingB.Text = sw.ElapsedMilliseconds.ToString() + " ms";
            sw = Stopwatch.StartNew();
            InsertionSort(clone);
            sw.Stop();
            textBoxInsertionSortProcessingB.Text = sw.ElapsedMilliseconds.ToString() + " ms";
            */
            //DisplayListBoxData(sensorB, listBoxSensorProcessingB);
            //UpdateAllListBoxes();
            SelectionSortAndDisplay(listBoxSensorProcessingB, sensorB, textBoxSelectionSortProcessingB);
            InsertionSortAndDisplay(listBoxSensorProcessingB, clone, textBoxInsertionSortProcessingB);
        }
        private void buttonSearchProcessingA_Click(object sender, EventArgs e)
        {
            bool sorted = IsSorted(sensorA);
            if (sorted && CheckInput(textBoxTargetProcessingA.Text, textBoxTargetProcessingA, sensorA))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingA.Text);
                LinkedList<double> clone = sensorA;
                Stopwatch sw = Stopwatch.StartNew();
                BinarySearchIterative(clone, searchValue);
                sw.Stop();
                textBoxIterativeSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw = Stopwatch.StartNew();
                int foundIndex = BinarySearchRecursive(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                sw.Stop();
                textBoxRecursiveSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw = Stopwatch.StartNew();
                HighlightData(listBoxSensorProcessingA, foundIndex, (int)numWheelSelectionRangeProcessingA.Value, (double)numWheelValueRangeProcessingA.Value);
                sw.Stop();
                textBoxHighlightProcessingSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
            }
            else if (!sorted)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingA, 45, 15, 3000);
                statusLabel.Text = "Error searching! Sensor A values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        private void buttonSearchProcessingB_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            bool sorted = IsSorted(sensorB);
            if (sorted && CheckInput(textBoxTargetProcessingB.Text, textBoxTargetProcessingB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingB.Text);
                LinkedList<double> clone = sensorB;
                Stopwatch sw = Stopwatch.StartNew();
                int foundIndex = BinarySearchIterative(clone, searchValue);
                sw.Stop();
                textBoxIterativeSearchSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw = Stopwatch.StartNew();
                foundIndex = BinarySearchRecursive(sensorB, searchValue, 0, NumberOfNodes(sensorA));
                sw.Stop();
                textBoxRecursiveSearchSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw = Stopwatch.StartNew();
                HighlightData(listBoxSensorProcessingB, foundIndex, (int)numWheelSelectionRangeProcessingB.Value, (double)numWheelValueRangeProcessingB.Value);
                sw.Stop();
                textBoxHighlightProcessingSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                clone.Clear();
            }
            else if (!sorted)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingB, 45, 15, 3000);
                statusLabel.Text = "Error searching! Sensor B values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }
        }
        private void textBoxTargetProcessingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric Input ONLY", textBoxTargetProcessingA, 45, 15, 3000);
        }
        private void textBoxTargetProcessingB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric Input ONLY", textBoxTargetProcessingB, 45, 15, 3000);
        }

    #endregion

    #region TAB Visualisation
        private void buttonLoadVisual_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorVisualA);
            DisplayListBoxData(sensorB, listBoxSensorVisualB);
        }
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "";
                Trace.TraceInformation("Displaying Charts of Sensor Data");
                SelectionSortAndDisplay(listBoxSensorVisualA, sensorA, textBoxSelectionSortVisual);
                InsertionSortAndDisplay(listBoxSensorVisualB, sensorB, textBoxInsertionSortVisual);
                chartSensorA.Series["SensorA"].Points.DataBindXY(sensorA, TotalOccurrences(sensorA));
                chartSensorB.Series["SensorB"].Points.DataBindXY(sensorB, TotalOccurrences(sensorB));
            }
            catch (InvalidOperationException ex)
            {
                statusLabel.Text = "Error sorting sensor data. Load new data and try again.";
            }
        }

    #endregion

        #endregion

        #region FormEvents
        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            Trace.Listeners.Clear();
            string fileName = CheckFileDir("TraceOutput");
            Trace.Listeners.Add(new TextWriterTraceListener(fileName, "myListener"));
            
        }
        private void ProcessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trace.Flush();
        }
        #endregion


    }
}

