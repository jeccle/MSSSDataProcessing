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


/* Jasper Eccles
 * 30034164
 * MSSData Processing
 * Recieves data stream from DLL Galileo satellite. Data stream populates LinkedLists and is displayed in lists.
 * Data can be sorted using Selection and Insertion sorting algorithms. 
 * Data can be searched for using Iterative and Recursive searching algorithms.
 * ADD MIN AND MAX DATA VALUE RANGE DISPLAY
 */

namespace MSSSDataProcessing
{
    public partial class ProcessingForm : Form
    {
        public ProcessingForm()
        {
            InitializeComponent();
        }
        // 4.1 Create two data structures using the LinkedList<T>, The data must be of type “double”,  
        private LinkedList<double> sensorA = new LinkedList<double>();
        private LinkedList<double> sensorB = new LinkedList<double>();

        #region Global Methods
        // 4.2 Create a method called “LoadData” which will populate both LinkedLists.
        private void LoadData()
        {
            checkBoxSensorA.Checked = false;
            checkBoxSensorB.Checked = false;
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
            statusLabel.Text = "New data stream recieved.";
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
                    current = (double)listBox.Items[i];                 // Current value to be compared.
                    //Trace.WriteLine("Target: " + current + " - High: " + high + "\t| Low:" + low + " \t| Value Deviation range: " + valueRange);
                    if (current > low && current < high)                // If current value is within upper and lower bounds.
                    {
                        listBox.SetSelected(i, true);                   // Specified index is set as selected within listBox.
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

        #region InputChecking
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

        // Checks input of the TextBox/String, if its empty user is prompted to re-enter appropriate value.
        // Checks input if its within range
        private bool CheckInput(TextBox TbTarget, LinkedList<double> sensor)
        {
            try
            {
                string TbInput = TbTarget.Text;
                Trace.TraceInformation("Checking input " + TbInput);
                if (string.IsNullOrEmpty(TbInput))
                {   // Empty text box input.
                    TbTarget.Focus();
                    toolTip.Show("Check input!", TbTarget, 60, 15, 3000);
                    statusLabel.Text = "Please enter an appropriate integer or decimal value";
                    Trace.TraceWarning("Input box is empty.\n");
                    return false;
                }
                else if (double.Parse(TbInput) < (int)sensor.First.Value || double.Parse(TbInput) > sensor.Last.Value)   // First value casted to int type to round lowest value to no decimal point.
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
            catch(NullReferenceException ex)
            {
                // Error thrown if sensor has no values.
                statusLabel.Text = "Error finding value, list may be empty.";
                Trace.TraceError("Empty list error: " + ex);
                return false;
            }
        }

        // Checks if input string is an integer, if true return the integer, if not cast 
        private double IntOrDouble(string TbInput)
        {
            bool isInt = int.TryParse(TbInput, out int result);
            if (!isInt)
                return double.Parse(TbInput);
            else
                return result;
        }
        private LinkedList<int> TotalOccurrences(LinkedList<double> sensor, CheckBox sortedBox)
        {
            LinkedList<int> result = new LinkedList<int>();
            if (sortedBox.Checked)
            {
                foreach (double data in sensor)
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
        {   // Checks if the first value is inbetween both the minimum value and maximum value.
            return value >= min && value <= max;
        }
        private bool IsSorted(LinkedList<double> sensor)
        {   // Loop continues untill the next value is greater than current value.
            int count = NumberOfNodes(sensor) - 1;
            for (int i = count; i > 0; i--) // If a failed sort is not found loop continues in background.
            {
                if (sensor.ElementAt(i) < sensor.ElementAt(i - 1)) {
                    statusLabel.Text = "Not sorted...";
                    return false;
                }
            }
            return true;
        }


        #endregion
        #endregion

        #region Sort & Search Methods
        private void SortSwap(int min, int current, LinkedList<double> sensor)
        {   // First value is left value of the current value, second is the current value, the sensor specifies which LinkedList must be searched.
            LinkedListNode<double> currentLeft = sensor.Find(sensor.ElementAt(min));
            LinkedListNode<double> currentNode = sensor.Find(sensor.ElementAt(current));
            double temp = currentLeft.Value;                // Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current pointer Value " + currentI.Value + "\t| " + currentMin.Value + " > " + currentI.Value + " swapping.");
            currentLeft.Value = currentNode.Value;      
            currentNode.Value = temp;
        }
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while the calling code argument is the linkedlist name. 
        private bool SelectionSort(LinkedList<double> sensor)
        {
                int min, max = NumberOfNodes(sensor);
                for (int i = 0; i < max; i++)
                {
                    min = i;
                    for (int j = i + 1; j < max; j++)
                    {
                        if (sensor.ElementAt(j) < sensor.ElementAt(min))    // If sensor to the left is less than sensor element on the right, raise the minimum value to the right.
                            min = j;                                        // else continue iterating
                    }
                    SortSwap(min, i, sensor);
                    /*
                    LinkedListNode<double> currentMin = sensor.Find(sensor.ElementAt(min));
                    LinkedListNode<double> currentI = sensor.Find(sensor.ElementAt(i));
                    //Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current pointer Value " + currentI.Value + "\t| " + currentMin.Value + " > " + currentI.Value + " swapping.");
                    double temp = currentMin.Value;
                    currentMin.Value = currentI.Value;      // Swaps the found minimum with the I current pointer value as the minimum is currently the lowest value in the list.
                    currentI.Value = temp;                  // Minimum values are shuffled down using selection sort.
                    */
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
                        // Trace.WriteLine("Left Value: " + currentLeft.Value + " | Current Value: " + current.Value + "\t| " + currentLeft.Value + " > " + current.Value + " swapping.");
                        
                        double temp = current.Value;
                        current.Value = currentLeft.Value;
                        currentLeft.Value = temp;
                        // SortSwap(j - 1, j, sensor);
                    }
                    // else
                    // Trace.WriteLine(sensor.ElementAt(j - 1) + " < " + sensor.ElementAt(j));
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
                int mid = (min + max) / 2;                                                              // Leaving out this code speeds up the algorithm. 
                /*
                if (IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5))    // searchValue == sensor.ElementAt(mid) || 
                    return mid;                                                                         // Doesn't seem to affect accuracy of search.
                else if (searchValue > sensor.ElementAt(mid))
                    min = mid + 1;
                else
                    max = mid - 1;
                
                
                */
                if (IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5))// searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid)
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
                if (IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5))
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
                /*
                mid = (min + max) / 2;                  // Compares if the specified element is within the +/-0.5 boundary of searchValue. OR if it matches the searchValue directly
                if (IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5)) // searchValue == sensor.ElementAt(mid) || 
                    return mid;                                              
                else if (searchValue < sensor.ElementAt(mid))  // Specified element is larger than the search value, shift focus to left.             
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                else                                           // Specified element is larger than the search value, shift focus to left.
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                
                
                */
            }
            return min;
        }

        // Methods contain both sort, display, and timer functions.
        #region MiscSort
        // Sort and display using insertion sort algorithm. Outputs process speed using stopwatch object.
        private bool InsertionSortAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox)
        {
            try
            {
                Trace.TraceInformation("Starting stopwatch   | Sort: Insertion");
                Stopwatch sw = Stopwatch.StartNew();
                bool sorted = InsertionSort(list);
                sw.Stop();
                textBox.Text = sw.ElapsedMilliseconds.ToString() + " ms";
                DisplayListBoxData(list, listBox);
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                return sorted;
            }
            catch(Exception ex)
            {
                statusLabel.Text = "Error during Insertion Sort";
                Trace.TraceError(ex.Message);
                MessageBox.Show(ex.Message, "Insertion Sort");
                return false;
            }
        }
        // Sort and display using selection sort algorithm. Outputs process speed using stopwatch object.
        private bool SelectionSortAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox)
        {       
            try
            {
                //Task.Delay(100);
                Trace.TraceInformation("Starting stopwatch   | Sort: Selection");
                Stopwatch sw = Stopwatch.StartNew();
                bool sorted = SelectionSort(list);
                sw.Stop();
                textBox.Text = sw.ElapsedMilliseconds.ToString() + " ms";
                DisplayListBoxData(list, listBox);
                Trace.TraceInformation("Stopping stopwatch   | Sort time: " + sw.Elapsed.TotalMilliseconds + "\n");
                return sorted;
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error during Selection Sort";
                Trace.TraceError(ex.Message);
                MessageBox.Show(ex.Message, "Selection Sort");
                return false;
            }

        }
        #endregion

        #endregion

        #region UI Button Methods

        // Region for MAIN tab, contains related control events.
        #region TAB Main
        // 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.The input parameters are empty, and the return type is void.
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxSensorA);
            DisplayListBoxData(sensorB, listBoxSensorB);
        }
        // 4.12 Create button click methods that will sort the LinkedList using the Selection and Insertion methods.
        private void buttonSortA_Click(object sender, EventArgs e)
        {
            int sortNum = RadioButtonIndex("SortA");
            // Selection Sort is selected.
            if (sortNum == 1)
            {
                checkBoxSensorA.Checked = SelectionSortAndDisplay(listBoxSensorA, sensorA, textBoxSortSpdA); ;
                ShowAllSensorData();
                // DisplayListBoxData(sensorA, listBoxSensorA);
                statusLabel.Text = "Sensor A has been sorted using Selection Sort.";
            }
            // Insertion Sort is selected.
            else if (sortNum == 0)
            {
                checkBoxSensorA.Checked = InsertionSortAndDisplay(listBoxSensorA, sensorA, textBoxSortSpdA); ;
                ShowAllSensorData();
                // DisplayListBoxData(sensorA, listBoxSensorA);
                statusLabel.Text = "Sensor A has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 4.12 Continued
        private void buttonSortB_Click(object sender, EventArgs e)
        {
            int sortNum = RadioButtonIndex("SortB");
            // Selection Sort is selected.
            if (sortNum == 1)
            {
                checkBoxSensorB.Checked = SelectionSortAndDisplay(listBoxSensorB, sensorB, textBoxSortSpdB);
                ShowAllSensorData();
                // DisplayListBoxData(sensorB, listBoxSensorB);
                statusLabel.Text = "Sensor B has been sorted using Selection Sort.";
            }
            // Insertion Sort is selected.
            else if (sortNum == 0)
            {
                checkBoxSensorB.Checked = InsertionSortAndDisplay(listBoxSensorB, sensorB, textBoxSortSpdB);
                ShowAllSensorData();
                statusLabel.Text = "Sensor B has been sorted using Insertion Sort.";
            }
            else
                MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 4.11	Create button click methods that will search the LinkedList for a value entered into a textbox on the form.
        private void buttonSearchA_Click(object sender, EventArgs e)
        {
            // If the corresponding checkBox is ticked it indicates the sort has been run, which means it should be successfully sorted.
            if (checkBoxSensorA.Checked && CheckInput(textBoxTargetA, sensorA))
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
            else if (!checkBoxSensorA.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortA, 45, 15, 3000);
                statusLabel.Text = "Sensor A values not sorted. Cannot search";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        // 4.11 Continued
        private void buttonSearchB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            if (checkBoxSensorB.Checked && CheckInput(textBoxTargetB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetB.Text);
                int searchNum = RadioButtonIndex("SearchB");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                    sw.Start();
                    int foundIndex = BinarySearchIterative(sensorB, searchValue);
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "  | Searching using Iterative Binary Search";
                    textBoxSearchSpdB.Text = sw.ElapsedTicks.ToString() + " Ticks";
                    HighlightData(listBoxSensorB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelValueRangeB.Value);
                }
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Starting stopwatch   | Binary Search: Recursive");
                    sw.Start();
                    int foundIndex = BinarySearchRecursive(sensorB, searchValue, 0, NumberOfNodes(sensorB));
                    sw.Stop();
                    Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
                    statusLabel.Text = "Search value: " + searchValue + "  Found: " + sensorB.ElementAt(foundIndex) + "  | Searching using Recursive Binary Search";
                    textBoxSearchSpdB.Text = sw.ElapsedTicks.ToString() + " Ticks";
                    HighlightData(listBoxSensorB, foundIndex, (int)numWheelSelRangeB.Value, (double)numWheelValueRangeB.Value);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeB, 65, 20, 3000);
            }
            else if (!checkBoxSensorB.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortB, 45, 15, 3000);
                statusLabel.Text = "Sensor B values not sorted. Cannot search";
                Trace.TraceWarning("SensorB attempted to search but its not sorted!?!?");
            }
        }
        // 4.14 Add two text boxes for the search value.
        // Keypress restrictions for target 
        private void textBoxTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetA, 45, 15, 3000);

        }
        private void textBoxTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetB, 45, 15, 3000);
        }

        #endregion

        // Region for PROCESSING tab, contains related control events.
        #region TAB Processing
        private void buttonLoadProcessing_Click(object sender, EventArgs e)
        {   // Load data into LinkedLists, loads all information into sensor processing listBox.
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorProcessingA);
            DisplayListBoxData(sensorB, listBoxSensorProcessingB);
        }
        private void buttonSortProcessingA_Click(object sender, EventArgs e)
        {
            LinkedList<double> clone = sensorA;             // Create clone LinkedList so insertion sort can be tested under same environment.
            checkBoxSensorA.Checked = SelectionSortAndDisplay(listBoxSensorProcessingA, sensorA, textBoxSelectionSortProcessingA);  // Both sorts are called.
            InsertionSortAndDisplay(listBoxSensorProcessingA, clone, textBoxInsertionSortProcessingA);                              // Processing times are outputted to textboxes.
        }
        private void buttonSortProcessingB_Click(object sender, EventArgs e)
        {
            LinkedList<double> clone = sensorB;             // Create clone LinkedList so insertion sort can be tested under same environment.
            checkBoxSensorB.Checked = SelectionSortAndDisplay(listBoxSensorProcessingB, sensorB, textBoxSelectionSortProcessingB);  // Both sorts are called.
            InsertionSortAndDisplay(listBoxSensorProcessingB, clone, textBoxInsertionSortProcessingB);                              // Processing times are outputted to textboxes.    
        }
        private void buttonSearchProcessingA_Click(object sender, EventArgs e)
        {
           
            if (checkBoxSensorA.Checked && CheckInput(textBoxTargetProcessingA, sensorA))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingA.Text);
                LinkedList<double> clone = sensorA;
                Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                Stopwatch sw = Stopwatch.StartNew();
                BinarySearchIterative(clone, searchValue);
                sw.Stop();
                textBoxIterativeSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw.Restart();
                int foundIndex = BinarySearchRecursive(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                sw.Stop();
                textBoxRecursiveSearchSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw.Restart();
                HighlightData(listBoxSensorProcessingA, foundIndex, (int)numWheelSelectionRangeProcessingA.Value, (double)numWheelValueRangeProcessingA.Value);
                sw.Stop();
                textBoxHighlightProcessingSpdA.Text = sw.ElapsedTicks.ToString() + " ticks.";
            }
            else if (!checkBoxSensorA.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingA, 45, 15, 3000);
                statusLabel.Text = "Error searching! Sensor A values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        private void buttonSearchProcessingB_Click(object sender, EventArgs e)
        {
            if (checkBoxSensorB.Checked && CheckInput(textBoxTargetProcessingB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingB.Text);
                LinkedList<double> clone = sensorB;
                Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
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
                // clone.Clear();
            }
            else if (!checkBoxSensorB.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingB, 45, 15, 3000);
                statusLabel.Text = "Error searching! Sensor B values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }
        }
        private void textBoxTargetProcessingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetProcessingA, 45, 15, 3000);
        }
        private void textBoxTargetProcessingB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.';
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetProcessingB, 45, 15, 3000);
        }

        #endregion

        // Region for VISUALISATION tab, contains related control events.
        #region TAB Visualisation
        private void buttonLoadVisual_Click(object sender, EventArgs e)     // Load button located within Visualisation Tab.
        {
            statusLabel.Text = "";
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorVisualA);
            DisplayListBoxData(sensorB, listBoxSensorVisualB);
        }
        private void buttonColumn_Click(object sender, EventArgs e)     // Sorts both listBoxes & LinkedLists then displaying them in both display graphs. 
        {                                                               // Uses both Selection & Insertion sorts and displays processing speed to text boxes.
            try
            {
                statusLabel.Text = "";
                Trace.TraceInformation("Displaying Charts of Sensor Data");
                checkBoxSensorA.Checked = SelectionSortAndDisplay(listBoxSensorVisualA, sensorA, textBoxSelectionSortVisual);
                checkBoxSensorB.Checked = InsertionSortAndDisplay(listBoxSensorVisualB, sensorB, textBoxInsertionSortVisual);
                chartSensorA.Series["SensorA"].Points.DataBindXY(sensorA, TotalOccurrences(sensorA, checkBoxSensorA));
                chartSensorB.Series["SensorB"].Points.DataBindXY(sensorB, TotalOccurrences(sensorB, checkBoxSensorB));      // Charts are populated.
            }
            catch (InvalidOperationException ex)
            {
                statusLabel.Text = "Error sorting sensor data. Load new data and try again.";
            }
        }
        private void numWheelSigmaVisual_ValueChanged(object sender, EventArgs e)
        {
            numWheelSigma.Value = numWheelSigmaVisual.Value;
        }
        private void numWheelMeanVisual_ValueChanged(object sender, EventArgs e)
        {
            numWheelMean.Value = numWheelMeanVisual.Value;
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
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxSensorProcessingA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
            checkBoxSensorProcessingB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }

        #region CheckBoxSortStatus 
        // IsSorted method is called within each of these event methods, the check to make sure the list is appropriately sorted updating the checkboxes.
        private void checkBoxSensorA_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSensorProcessingA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked;
        }
        private void checkBoxSensorB_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSensorProcessingB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked;
        }
        private void listBoxSensorA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        private void listBoxSensorB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }
        private void listBoxSensorProcessingA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        private void listBoxSensorProcessingB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }
        private void listBoxSensorVisualA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        private void listBoxSensorVisualB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorProcessingB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }



        #endregion

        #endregion

        private void DifferenceInValue(double target, double difference, TextBox textBox)
        {
            textBox.Text = "Min: " + (target - difference) + " Max: " + (target + difference);
        }

        private void numWheelValueRangeA_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetA.Text)) {
                DifferenceInValue(double.Parse(textBoxTargetA.Text), (double)numWheelValueRangeA.Value, textBoxDifferenceA);
            }
        }

        private void textBoxTargetA_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetA.Text))
            {
                DifferenceInValue(double.Parse(textBoxTargetA.Text), (double)numWheelValueRangeA.Value, textBoxDifferenceA);
            }
        }

        private void textBoxSearchSpdB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetB.Text))
            {
                DifferenceInValue(double.Parse(textBoxTargetB.Text), (double)numWheelValueRangeB.Value, textBoxDifferenceB);
            }
        }

        private void numWheelValueRangeB_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetB.Text))
            {
                DifferenceInValue(double.Parse(textBoxTargetB.Text), (double)numWheelValueRangeB.Value, textBoxDifferenceB);
            }
        }
    }
}

