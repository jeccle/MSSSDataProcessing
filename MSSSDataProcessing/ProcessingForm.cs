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
 * 
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
        /// <summary>
        /// Loads stream of data from Galileo satellite. Fills LinkedLists with double values.
        /// </summary>
        private void LoadData()
        {
            checkBoxSensorA.Checked = checkBoxSensorB.Checked = false;
            ReadData satellite = new ReadData();
            sensorA.Clear();
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
        /// <summary>
        /// Displays data from both sensor A & B within the ListView in the main tab.
        /// </summary>
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
        /// <summary>
        /// Displays content of a linked list within the specified ListBox. 
        /// Uses simple loop to step through each item of the list and displays using the ListBox.Items.Add() method.
        /// </summary>
        /// <param name="sensor">Values to be displayed within listBox.</param>
        /// <param name="listBox">listBox to display values.</param>
        private void DisplayListBoxData(LinkedList<double> sensor, ListBox listBox)
        {
            //Trace.TraceInformation("Displaying list  in listBox");
            listBox.Items.Clear();
            foreach (double data in sensor)
            {
                listBox.Items.Add(data);
            }
            //Trace.TraceInformation("Display list complete.\n");
        }
        // 4.5	Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList.
        /// <summary>
        /// When called takes a LinkedList of type double, returns the amount of values within the list.
        /// </summary>
        /// <param name="sensor">LinkedList of type double</param>
        /// <returns>Total number of values within the list.</returns>
        private int NumberOfNodes(LinkedList<double> sensor)
        {
            return sensor.Count;
        }
        /// <summary>
        /// Highlights a specific range from a target value, specifying the range in which values inside the list are checked.
        /// Takes 4 parameters specifying the target listBox, target index, range of values to check, and distance from target value.
        /// </summary>
        /// <param name="listBox">Target listBox that will have the changes applied.</param>
        /// <param name="index">Index value of the found item.</param>
        /// <param name="range">Range value counts the total span of the highlighting setting the maximum amount of values that can be selected at once</param>
        /// <param name="valueRange">The distance in value both positive and negative from the target value.</param>
        private void HighlightData(ListBox listBox, int index, int range, double valueRange)
        {
            try
            {
                listBox.SelectedItems.Clear();
                double low, high, current;                                          // Boundaries for value selection.
                low = (double)listBox.Items[index] - valueRange;                    // Low value set
                high = (double)listBox.Items[index] + valueRange;                   // High value set
                Trace.TraceInformation("Selection configuration\nTotal selection range: " + range + "\t| Value Deviation range: " + valueRange);
                Trace.TraceInformation("low: " + ((double)listBox.Items[index] - valueRange) + "\t| high: " + ((double)listBox.Items[index] + valueRange));
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
        /// <summary>
        /// Checks file dir and incrememnts upwards for each existing demo file until a new file number is reached.
        /// </summary>
        /// <param name="fileName">fileName string to be checked.</param>
        /// <returns>Updated fileName variable with an increased increment attached of +1</returns>
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
        /// <summary>
        /// Takes input parameter of a string and filters the selected radio buttons based on the input parameter.
        /// </summary>
        /// <param name="radioGrpName">Input string that which specifies the radio button control.</param>
        /// <returns>If top radio button is selected return 1
        /// If bottom radio button is selected return 0</returns>
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
        /// <summary>
        /// Checks input of the TextBox/String, if its empty user is prompted to re-enter appropriate value.
        /// Checks input if its within range
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="sensor"></param>
        /// <returns></returns>
        private bool CheckInput(TextBox textBox, LinkedList<double> sensor)
        {
            try
            {
                string TbInput = textBox.Text;
                Trace.TraceInformation("Checking input " + TbInput);
                if (string.IsNullOrEmpty(TbInput))
                {   // Empty text box input.
                    textBox.Focus();
                    toolTip.Show("Check input!", textBox, 70, 0, 3000);
                    statusLabel.Text = "Please enter an appropriate integer or decimal value";
                    Trace.TraceWarning("Input box is empty.\n");
                    return false;
                }
                else if (double.Parse(TbInput) < (int)sensor.First.Value || double.Parse(TbInput) > sensor.Last.Value)   // First value casted to int type to round lowest value to no decimal point.
                {   // Input is out of range
                    textBox.Focus();
                    toolTip.Show("Input is out of bounds!", textBox, 70, 0, 3000);
                    statusLabel.Text = "Please enter an appropriate value between " + sensor.First.Value + " and " + sensor.Last.Value;
                    textBox.Clear();
                    Trace.WriteLine(sensor.First.Value + " > " + TbInput + " & " + TbInput + " < " + sensor.Last.Value);
                    Trace.TraceWarning("Value is out of bounds.\n");
                    return false;
                }
                else
                    return true;
            }
            catch (NullReferenceException ex)
            {
                // Error thrown if sensor has no values.
                statusLabel.Text = "Error finding value, list may be empty.";
                Trace.TraceError("Empty list error: " + ex);
                return false;
            }
        }
        /// <summary>
        /// Checks if input string is an integer, if true return the integer, if not cast the value to a double data type.
        /// </summary>
        /// <param name="TbInput">Input string to be parsed</param>
        /// <returns>Result as double</returns>
        private double IntOrDouble(string TbInput)
        {
            bool isInt = int.TryParse(TbInput, out int result);
            if (!isInt)
                return double.Parse(TbInput);
            else
                return result;
        }
        /// <summary>
        /// Returns a LinkedList containing the count values of a sorted LinkedList. This value is to be used to visualise the data on a graph.
        /// </summary>
        /// <param name="sensor">Linked list with values to be counted.</param>
        /// <param name="sortedBox">Checkbox verifies that list is sorted.</param>
        /// <returns>LinkedList containing integer values describing the total occurences of each value within the input LinkedList</returns>
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
        /// <summary>
        /// Checks if the target value is within the positive and negative difference of the deviation value from the comparison value.
        /// The comparison value is directly compared using an == comparison.
        /// </summary>
        /// <param name="targetValue">Double target value to be counted.</param>
        /// <param name="deviation">Distance from comparison value double.</param>
        /// <param name="comparisonValue">Value to be compared against targetValue.</param>
        /// <returns>Boolean returns 
        /// <true>Returns true if target value is equal to comparison, or target value lies within the positive and negative bounds of the deviation value, from the comparison value.</true>
        /// <false>Returns false if the targetValue is not equal or within the bounds set by the deviation value in relation to the comparison value.</false>
        /// </returns>
        private bool IsWithinOrMatches(double targetValue, double deviation, double comparisonValue)
        {   // Checks if the first value is inbetween both the minimum value and maximum value.
            return targetValue == comparisonValue || targetValue > comparisonValue - deviation && targetValue < comparisonValue + deviation;
        }
        /// <summary>
        /// Determines whether first value lies within the bounds of the min and max values. 
        /// returns boolean.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>
        /// <true>Returns true if value lies inbetween min and max.</true>
        /// <false>Returns false if value is outside of bounds.</false>
        /// </returns>
        private bool IsWithin(double value, double min, double max)
        {   // Checks if the first value is inbetween both the minimum value and maximum value.
            return value >= min && value <= max;
        }
        /// <summary>
        /// Steps through a LinkedList iteratively checking if it is sorted by comparing each value.
        /// The loop continues and does a full pass if the list is sorted, meaning the lowest values are at the beginning.
        /// </summary>
        /// <param name="sensor">LinkedList of type double to be checked.</param>
        /// <returns>
        /// <true>Returns true if the LinkedList is sorted in ascending order.</true>
        /// <false>Returns false if the LinkedList is not sorted.</false>
        /// </returns>
        private bool IsSorted(LinkedList<double> sensor)
        {   // Loop continues untill the next value is greater than current value.
            int count = NumberOfNodes(sensor) - 1;
            for (int i = count; i > 0; i--) // If a failed sort is not found loop continues in background.
            {
                if (sensor.ElementAt(i) < sensor.ElementAt(i - 1))
                {
                    statusLabel.Text = "Sensor is NOT sorted. Load new data set to continue.";
                    return false;
                }
            }
            return true;
        }

        #endregion

        #endregion

        #region Sort & Search Methods
        /// <summary>
        /// Creates LinkedListNodes and assigns the left and current values to appropriate LinkedListNode objects.
        /// First value is left value of the current value, second is the current value, the sensor specifies which LinkedList must be searched.
        /// </summary>
        /// <param name="left">Index value found to the left of the current value within the list.</param>
        /// <param name="current">Current index value within the list.</param>
        /// <param name="sensor">LinkedList of type double specified for swapping indexed values at left and current.</param>
        private void SortSwap(int left, int current, LinkedList<double> sensor)
        {
            LinkedListNode<double> currentLeft = sensor.Find(sensor.ElementAt(left));
            LinkedListNode<double> currentNode = sensor.Find(sensor.ElementAt(current));
            double temp = currentLeft.Value;                // Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current pointer Value " + currentI.Value + "\t| " + currentMin.Value + " > " + currentI.Value + " swapping.");
            currentLeft.Value = currentNode.Value;
            currentNode.Value = temp;
        }
        // 4.7	Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while the calling code argument is the linkedlist name. 
        /// <summary>
        /// Selection sort algorithm has i as the step through each element within the list, the min gets the index of the lowest value found 
        /// within the list, j is the current value the gets compared to the current min value. If j is lower than min, min then equals j.
        /// SortSwap method swaps min and i index where i is the current index in the list which is the be populated by the lowest value in the list. 
        /// That lowest value is the min value.
        /// </summary>
        /// <param name="sensor">LinkedList of type double to be sorted.</param>
        /// <returns><true>Returns true if no errors occur and List is successfully sorted.</true></returns>
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
        /// <summary>
        /// Insertion sort steps through each element of the list. variable i is the value to be compared, j is the value to the left of i.
        /// As long as the value to the left of the current element is greater than the current value, it will be moved left through the list.
        /// </summary>
        /// <param name="sensor">LinkedList of type double to be sorted.</param>
        /// <returns><true>Returns true upon successful sort.</true></returns>
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
        /// <summary>
        /// Iterative binary search algorithm, checks if mid value matches the searchValue, checks if searchValue is greater than mid value, else.
        /// If searchValue is greater, the min value is increased to the mid value + 1.
        /// else the max value is reduced to mid - 1.
        /// </summary>
        /// <param name="sensor">LinkedList of type double to be searched.</param>
        /// <param name="searchValue"><double>Value to be searched within specified LinkedList</double></param>
        /// <returns><integer>Index of found value.</integer></returns>
        private int BinarySearchIterative(LinkedList<double> sensor, double searchValue)
        {
            int min = 0;
            int max = NumberOfNodes(sensor);
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;                                                              // Leaving out this code speeds up the algorithm. 

                if (IsWithinOrMatches(sensor.ElementAt(mid), 0.1, searchValue))    // searchValue == sensor.ElementAt(mid) || (IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5)
                    return mid;                                                                         // Doesn't seem to affect accuracy of search.
                else if (searchValue > sensor.ElementAt(mid))
                    min = mid + 1;
                else
                    max = mid - 1;
                // searchValue == sensor.ElementAt(mid) || IsWithin(searchValue, sensor.ElementAt(mid) - 0.3, sensor.ElementAt(mid) + 0.3)
                /*
                if (IsWithinOrMatches(sensor.ElementAt(mid), 0.1, searchValue)) // IsWithin(searchValue, sensor.ElementAt(mid) - 0.7, sensor.ElementAt(mid) + 0.3)
                {                                                               // Due to behaviour of the search, using 1 ad the range skewed further to the right may create a nicer search pattern.
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue > sensor.ElementAt(mid)) //  Need to check if its search value is greater than element at mid AND if search value is in between both element at mid and previous
                {
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Increasing min: " + (mid + 1) + " from: " + min + "\t\t| Shifting search range to right.");
                    min = mid + 1;
                }
                else
                {
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Decreasing max: " + (mid + 1) + " from: " + max + "\t\t| Shifting search range to left.");
                    max = mid - 1;
                }
                */
            }
            return min; // returns last found value
        }
        // 4.10	Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum. 
        /// <summary>
        /// Recursive binary search algorithm, checks if mid value matches the searchValue, checks if searchValue is less than mid value, else.
        /// If searchValue is less, the min value is decreased to the mid value - 1.
        /// </summary>
        /// <param name="sensor">LinkedList of type double to be searched.</param>
        /// <param name="searchValue">Double value acts as target value within the search algorithm</param>
        /// <param name="min">Minimum/floor value of algorithm</param>
        /// <param name="max">Maximum/roof value of algorithm</param>
        /// <returns>Integer index of the target value if found.</returns>
        private int BinarySearchRecursive(LinkedList<double> sensor, double searchValue, int min, int max)
        {
            int mid;
            while (min <= max - 1)
            {
                mid = (min + max) / 2;                  // Compares if the specified element is within the +/-0.5 boundary of searchValue. OR if it matches the searchValue directly
                if (IsWithinOrMatches(searchValue, 0.1, sensor.ElementAt(mid))) // searchValue == sensor.ElementAt(mid) || IsWithin(searchValue, sensor.ElementAt(mid) - 0.5, sensor.ElementAt(mid) + 0.5)
                    return mid;
                else if (searchValue < sensor.ElementAt(mid))  // Specified element is larger than the search value, shift focus to left.             
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                else                                           // Specified element is larger than the search value, shift focus to left.
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);

                /*
                if (IsWithinOrMatches(searchValue, 0.1, sensor.ElementAt(mid)))
                {
                    Trace.TraceInformation("Index " + mid + " has been found: " + sensor.ElementAt(mid));
                    return mid;
                }
                else if (searchValue < sensor.ElementAt(mid))
                {
                    Trace.WriteLine("Search value: " + searchValue + " < " + sensor.ElementAt(mid) + "\t|   Decreasing max: " + (mid - 1) + " from: " + max + "\t\t| Shifting search range to left.");
                    return BinarySearchRecursive(sensor, searchValue, min, mid - 1);
                }
                else
                {
                    Trace.WriteLine("Search value: " + searchValue + " > " + sensor.ElementAt(mid) + "\t|   Increasing min: " + (mid + 1) + " from: " + min + "\t\t| Shifting search range to right.");
                    return BinarySearchRecursive(sensor, searchValue, mid + 1, max);
                }
                */

            }
            return min;
        }

        // Methods contain both sort, display, and timer functions.
        #region MiscSort&Search
        /// <summary>
        /// Contains InsertionSort method and displays the updates values after the list has been sorted.
        /// Starts a stopwatch and updates form status messages.
        /// Sort and display using insertion sort algorithm. Outputs process speed using stopwatch object.
        /// </summary>
        /// <param name="listBox">Specify listBox to display the updated/sorted list.</param>
        /// <param name="list">LinkedList of type double to be sorted using insertion sort.</param>
        /// <param name="textBox">textBox to display the elapsed milliseconds of the sort.</param>
        /// <returns>Boolean return true if sort is successful.</returns>
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
            catch (Exception ex)
            {
                statusLabel.Text = "Error during Insertion Sort";
                Trace.TraceError(ex.Message);
                MessageBox.Show(ex.Message, "Insertion Sort");
                return false;
            }
        }
        /// <summary>
        /// Sort and display using selection sort algorithm. Outputs process speed using stopwatch object.
        /// </summary>
        /// <param name="listBox">Specify listBox to display the updated/sorted list.</param>
        /// <param name="list">LinkedList of type double to be sorted using selection sort.</param>
        /// <param name="textBox">textBox to display the elapsed milliseconds of the sort.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Uses stopwatch to time speed of Iterative binary search algorithm and then highlight the appropriate data.
        /// </summary>
        /// <param name="listBox">listBox to have values selected.</param>
        /// <param name="list">LinkedList of type double to be searched.</param>
        /// <param name="textBox">textBox to display elapsed ticks of search.</param>
        /// <param name="searchValue">Target value of the search.</param>
        /// <param name="selRange">Selection range specifies the total elements within the list which can be selected at once.</param>
        /// <param name="valueRange">Value range specifies the distance from the found index in which values can be selected.</param>
        /// <returns>Returns the found index of the search</returns>
        private int IterativeSearchAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox, double searchValue, int selRange, double valueRange)
        {

            Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
            Stopwatch sw = Stopwatch.StartNew();                                                     // Beginning of stopwatch timer.
            int foundIndex = BinarySearchIterative(list, searchValue);
            sw.Stop();                                                      // End of stopwatch timer.
            Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
            textBox.Text = sw.ElapsedTicks.ToString() + " ticks.";                 // Total time in ms displayed to textBox.
            statusLabel.Text = "Search value: " + searchValue + "  Found: " + list.ElementAt(foundIndex) + "  | Searching using Iterative Binary Search";
            HighlightData(listBox, foundIndex, selRange, valueRange); // Added input from controls
            return foundIndex;  // First int is mid index, second int is the range of values to be checked.Third int is the value range deviation.
        }
        /// <summary>
        /// Uses stopwatch to time speed of Recursive binary search algorithm and then highlight the appropriate data.
        /// </summary>
        /// <param name="listBox">listBox to have values selected.</param>
        /// <param name="list">LinkedList of type double to be searched.</param>
        /// <param name="textBox">textBox to display elapsed ticks of search.</param>
        /// <param name="searchValue">Target value of the search.</param>
        /// <param name="selRange">Selection range specifies the total elements within the list which can be selected at once.</param>
        /// <param name="valueRange">Value range specifies the distance from the found index in which values can be selected.</param>
        /// <returns>Returns the found index of the search</returns>
        private int RecursiveSearchAndDisplay(ListBox listBox, LinkedList<double> list, TextBox textBox, double searchValue, int selRange, double valueRange)
        {
            Trace.TraceInformation("Starting stopwatch   | Binary Search: Recursive");
            Stopwatch sw = Stopwatch.StartNew();                                                     // Beginning of stopwatch timer.
            int foundIndex = BinarySearchRecursive(list, searchValue, 0, NumberOfNodes(list));
            sw.Stop();                                                      // End of stopwatch timer.
            Trace.TraceInformation("Stopping stopwatch   | Search time: " + sw.Elapsed.TotalMilliseconds.ToString() + "\n");
            textBox.Text = sw.ElapsedTicks.ToString() + " ticks.";                 // Total time in ms displayed to textBox.
            statusLabel.Text = "Search value: " + searchValue + "  Found: " + list.ElementAt(foundIndex) + "  | Searching using Recursive Binary Search";
            HighlightData(listBox, foundIndex, selRange, valueRange); // Added input from controls
            return foundIndex;  // First int is mid index, second int is the range of values to be checked.Third int is the value range deviation.
        }

        #endregion

        #endregion

        #region UI Button Methods
        // Region for MAIN tab, contains related control events.
        #region TAB Main
        // 4.4	Create a button and associated click method that will call the LoadData and ShowAllSensorData methods.The input parameters are empty, and the return type is void.
        /// <summary>
        /// Calls LoadData() method recieve data from galileo satellite, ShowAllSensorData() then display data from both Lists in listView
        /// Both listBoxes are populated using DisplayListBoxData() method.
        /// </summary>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            LoadData();
            ShowAllSensorData();
            DisplayListBoxData(sensorA, listBoxSensorA);
            DisplayListBoxData(sensorB, listBoxSensorB);
        }
        // 4.12 Create button click methods that will sort the LinkedList using the Selection and Insertion methods.
        /// <summary>
        /// Button click method filters sort method based on radio button status for SensorA.
        /// </summary>
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
            else //if (sortNum == 0)
            {
                checkBoxSensorA.Checked = InsertionSortAndDisplay(listBoxSensorA, sensorA, textBoxSortSpdA); ;
                ShowAllSensorData();
                // DisplayListBoxData(sensorA, listBoxSensorA);
                statusLabel.Text = "Sensor A has been sorted using Insertion Sort.";
            }
            //else
            //MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 4.12 Continued
        /// <summary>
        /// Button click method filters sort method based on radio button status for SensorB.
        /// </summary>
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
            else //if (sortNum == 0)
            {
                checkBoxSensorB.Checked = InsertionSortAndDisplay(listBoxSensorB, sensorB, textBoxSortSpdB);
                ShowAllSensorData();
                statusLabel.Text = "Sensor B has been sorted using Insertion Sort.";
            }
            //else
            //MessageBox.Show("Something is wrong with the radio box!!", "What's happening???", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 4.11	Create button click methods that will search the LinkedList for a value entered into a textbox on the form.
        /// <summary>
        /// Button click method filters search method based on radio button status for SensorA.
        /// </summary>
        private void buttonSearchA_Click(object sender, EventArgs e)
        {
            // If the corresponding checkBox is ticked it indicates the sort has been run, which means it should be successfully sorted.
            if (checkBoxSensorA.Checked && CheckInput(textBoxTargetA, sensorA))
            {
                double searchValue = IntOrDouble(textBoxTargetA.Text);
                int searchNum = RadioButtonIndex("SearchA");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Search Main Sensor A");
                    int foundIndex = IterativeSearchAndDisplay(listBoxSensorA, sensorA, textBoxSearchSpdA, searchValue, (int)numWheelSelectionRangeA.Value, (double)numWheelValueRangeA.Value);
                    textBoxDifferenceA.Text = "Min: " + (sensorA.ElementAt(foundIndex) - (double)numWheelValueRangeA.Value) + " |  Max: " + (sensorA.ElementAt(foundIndex) + (double)numWheelValueRangeA.Value);
                }
                else //if (searchNum == 0)
                {
                    Trace.TraceInformation("Search Main Sensor A");
                    int foundIndex = RecursiveSearchAndDisplay(listBoxSensorA, sensorA, textBoxSearchSpdA, searchValue, (int)numWheelSelectionRangeA.Value, (double)numWheelValueRangeA.Value);
                    textBoxDifferenceA.Text = "Min: " + (sensorA.ElementAt(foundIndex) - (double)numWheelValueRangeA.Value) + " |  Max: " + (sensorA.ElementAt(foundIndex) + (double)numWheelValueRangeA.Value);
                }

            }
            else if (!checkBoxSensorA.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortA, 45, -10, 3000);
                statusLabel.Text = "Sensor A values not sorted. Cannot search";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        // 4.11 Continued
        /// <summary>
        /// Button click method filters search method based on radio button status for SensorB.
        /// </summary>
        private void buttonSearchB_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            if (checkBoxSensorB.Checked && CheckInput(textBoxTargetB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetB.Text);
                int searchNum = RadioButtonIndex("SearchB");
                if (searchNum == 1)
                {
                    Trace.TraceInformation("Search Main Sensor B");
                    int foundIndex = IterativeSearchAndDisplay(listBoxSensorB, sensorB, textBoxSearchSpdB, searchValue, (int)numWheelSelectionRangeB.Value, (double)numWheelValueRangeB.Value);
                    textBoxDifferenceB.Text = "Min: " + (sensorB.ElementAt(foundIndex) - (double)numWheelValueRangeB.Value) + " |  Max: " + (sensorB.ElementAt(foundIndex) + (double)numWheelValueRangeB.Value);
                }
                else if (searchNum == 0)
                {
                    Trace.TraceInformation("Search Main Sensor B");
                    int foundIndex = RecursiveSearchAndDisplay(listBoxSensorB, sensorB, textBoxSearchSpdB, searchValue, (int)numWheelSelectionRangeB.Value, (double)numWheelValueRangeB.Value);
                    textBoxDifferenceB.Text = "Min: " + (sensorB.ElementAt(foundIndex) - (double)numWheelValueRangeB.Value) + " |  Max: " + (sensorB.ElementAt(foundIndex) + (double)numWheelValueRangeB.Value);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeB, 65, 20, 3000);
            }
            else if (!checkBoxSensorB.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortB, 45, -10, 3000);
                statusLabel.Text = "Sensor B values not sorted. Cannot search";
                Trace.TraceWarning("SensorB attempted to search but its not sorted!?!?");
            }
        }
        // 4.14 Add two text boxes for the search value.
        /// <summary>
        /// Keypress restrictions for target 
        /// </summary>
        private void textBoxTargetA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetA, 70, 0, 3000);
        }
        /// <summary>
        /// Keypress restrictions for target 
        /// </summary>
        private void textBoxTargetB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetB, 70, 0, 3000);
        }
        /// <summary>
        /// When the value of numWheelValueRangeA control changes, the difference in value from the target value is displayed to textBoxTargetA
        /// </summary>
        private void numWheelValueRangeA_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetA.Text))
            {
                DifferenceInValue(double.Parse(textBoxTargetA.Text), (double)numWheelValueRangeA.Value, textBoxDifferenceA);
            }
        }
        /// <summary>
        /// When the value of numWheelValueRangeB control changes, the difference in value from the target value is displayed to textBoxTargetB
        /// </summary>
        private void numWheelValueRangeB_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetB.Text))
            {
                DifferenceInValue(double.Parse(textBoxTargetB.Text), (double)numWheelValueRangeB.Value, textBoxDifferenceB);
            }
        }
        /// <summary>
        /// When the value of textBoxTargetA control changes, the difference in value from the target value is displayed to textBoxTargetA
        /// </summary>
        private void textBoxTargetA_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetA.Text) && !textBoxTargetA.Text.StartsWith(".") && !textBoxTargetA.Text.EndsWith("."))
            {
                DifferenceInValue(double.Parse(textBoxTargetA.Text), (double)numWheelValueRangeA.Value, textBoxDifferenceA);
            }
        }
        /// <summary>
        /// When the value of textBoxTargetB control changes, the difference in value from the target value is displayed to textBoxTargetB
        /// </summary>
        private void textBoxTargetB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTargetB.Text) && !textBoxTargetB.Text.StartsWith(".") && !textBoxTargetB.Text.EndsWith("."))
            {
                DifferenceInValue(double.Parse(textBoxTargetB.Text), (double)numWheelValueRangeB.Value, textBoxDifferenceB);
            }
        }
        /// <summary>
        /// Changes specified text box to output string containing the positive and negative differences from the target.
        /// </summary>
        /// <param name="target">Target value taken from text box.</param>
        /// <param name="difference">Value from target in which values can be selected in both positive and negative directions.</param>
        /// <param name="textBox">textBox to display output string.</param>
        private void DifferenceInValue(double target, double difference, TextBox textBox)
        {
            textBox.Text = "Min: " + (target - difference) + " |  Max: " + (target + difference);
        }
        #endregion
        // Region for PROCESSING tab, contains related control events.
        #region TAB Processing
        /// <summary>
        /// Calls LoadData() method recieve data from galileo satellite, ShowAllSensorData() then display data from both Lists in listView
        /// Both listBoxes are populated using DisplayListBoxData() method.
        /// Load data into LinkedLists, loads all information into sensor processing listBox.
        /// </summary>
        private void buttonLoadProcessing_Click(object sender, EventArgs e)
        {
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorProcessingA);
            DisplayListBoxData(sensorB, listBoxSensorProcessingB);
        }
        /// <summary>
        /// Creates a clone of LinkedList sensorA, calls both SelectionSortAndDisplay & InsertionSortAndDisplay methods. Processing speed is outputted to specified textBox.
        /// </summary>
        private void buttonSortProcessingA_Click(object sender, EventArgs e)
        {
            LinkedList<double> clone = sensorA;             // Create clone LinkedList so insertion sort can be tested under same environment.
            checkBoxSensorA.Checked = SelectionSortAndDisplay(listBoxSensorProcessingA, sensorA, textBoxSelectionSortProcessingA);  // Both sorts are called.
            InsertionSortAndDisplay(listBoxSensorProcessingA, clone, textBoxInsertionSortProcessingA);                              // Processing times are outputted to textboxes.
        }
        /// <summary>
        /// Creates a clone of LinkedList sensorB, calls both SelectionSortAndDisplay & InsertionSortAndDisplay methods. Processing speed is outputted to specified textBox.
        /// </summary>
        private void buttonSortProcessingB_Click(object sender, EventArgs e)
        {
            LinkedList<double> clone = sensorB;             // Create clone LinkedList so insertion sort can be tested under same environment.
            checkBoxSensorB.Checked = SelectionSortAndDisplay(listBoxSensorProcessingB, sensorB, textBoxSelectionSortProcessingB);  // Both sorts are called.
            InsertionSortAndDisplay(listBoxSensorProcessingB, clone, textBoxInsertionSortProcessingB);                              // Processing times are outputted to textboxes.    
        }
        /// <summary>
        /// Creates a clone of LinkedList sensorA, starts a stopwatch and searches for searchValue using binarySearchIterative algoirthm using clone LinkedList.
        /// Speed is recorded and outputted to textBox, stopwatch is restarted and binarySearchRecursive algorithm is then used using sensorA.
        /// Processing speed is output to textBox, values are highlights within listBox and highlight speed is outputted to textBox.
        /// </summary>
        private void buttonSearchProcessingA_Click(object sender, EventArgs e)
        {

            if (checkBoxSensorA.Checked && CheckInput(textBoxTargetProcessingA, sensorA))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingA.Text);
                LinkedList<double> clone = sensorA;
                Trace.TraceInformation("Search Processing Sensor A");
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
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingA, 90, -10, 3000);
                statusLabel.Text = "Error searching! Sensor A values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }

        }
        /// <summary>
        /// Creates a clone of LinkedList sensorB, starts a stopwatch and searches for searchValue using binarySearchIterative algoirthm using clone LinkedList.
        /// Speed is recorded and outputted to textBox, stopwatch is restarted and binarySearchRecursive algorithm is then used using sensorA.
        /// Processing speed is output to textBox, values are highlights within listBox and highlight speed is outputted to textBox.
        /// </summary>
        private void buttonSearchProcessingB_Click(object sender, EventArgs e)
        {
            if (checkBoxSensorB.Checked && CheckInput(textBoxTargetProcessingB, sensorB))
            {
                double searchValue = IntOrDouble(textBoxTargetProcessingB.Text);
                LinkedList<double> clone = sensorB;
                Trace.TraceInformation("Search Processing Sensor B");
                Trace.TraceInformation("Starting stopwatch   | Binary Search: Iterative");
                Stopwatch sw = Stopwatch.StartNew();
                int foundIndex = BinarySearchIterative(clone, searchValue);
                sw.Stop();
                textBoxIterativeSearchSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw.Restart();
                foundIndex = BinarySearchRecursive(sensorB, searchValue, 0, NumberOfNodes(sensorA));
                sw.Stop();
                textBoxRecursiveSearchSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                sw.Restart();
                HighlightData(listBoxSensorProcessingB, foundIndex, (int)numWheelSelectionRangeProcessingB.Value, (double)numWheelValueRangeProcessingB.Value);
                sw.Stop();
                textBoxHighlightProcessingSpdB.Text = sw.ElapsedTicks.ToString() + " ticks.";
                // clone.Clear();
            }
            else if (!checkBoxSensorB.Checked)
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortProcessingB, 90, -10, 3000);
                statusLabel.Text = "Error searching! Sensor B values not sorted.";
                Trace.TraceWarning("SensorA attempted to search but its not sorted!?!?");
            }
        }
        /// <summary>
        /// Keypress restrictions of textBoxTargetProcessingA control.
        /// Allows only digits, decimal points as input.
        /// </summary>
        private void textBoxTargetProcessingA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetProcessingA, 70, 0, 3000);
        }
        /// <summary>
        /// Keypress restrictions of textBoxTargetProcessingB control.
        /// Allows only digits, decimal points as input.
        /// </summary>
        private void textBoxTargetProcessingB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
            if (e.Handled)
                toolTip.Show("Numeric/Decimal Input ONLY", textBoxTargetProcessingB, 70, 0, 3000);
        }

        #endregion
        // Region for VISUALISATION tab, contains related control events.
        #region TAB Visualisation
        /// <summary>
        /// Load button located within Visualisation Tab.
        /// Calls LoadData() method recieve data from galileo satellite, ShowAllSensorData() then display data from both Lists in listBoxes.
        /// Both listBoxes are populated using DisplayListBoxData() method.
        /// </summary>
        private void buttonLoadVisual_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            LoadData();
            DisplayListBoxData(sensorA, listBoxSensorVisualA);
            DisplayListBoxData(sensorB, listBoxSensorVisualB);
        }
        /// <summary>
        /// Sorts both listBoxes & LinkedLists then displaying them in both display graphs. 
        /// Uses both Selection & Insertion sorts and displays processing speed to text boxes.
        /// </summary>
        private void buttonColumn_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "";
                Trace.TraceInformation("Displaying Sensor Data Charts");
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
        /// <summary>
        /// Keeps both number wheels consistent throughout the application.
        /// </summary>
        private void numWheelSigmaVisual_ValueChanged(object sender, EventArgs e)
        {
            numWheelSigma.Value = numWheelSigmaVisual.Value;
        }
        /// <summary>
        /// Keeps both number wheels consistent throughout the application.
        /// </summary>
        private void numWheelMeanVisual_ValueChanged(object sender, EventArgs e)
        {   // Keeps both number wheels consistent throughout the application.
            numWheelMean.Value = numWheelMeanVisual.Value;
        }
        #endregion

        #endregion

        #region FormEvents
        /// <summary>
        /// Makes new file name, adds new TraceListener
        /// </summary>
        private void ProcessingForm_Load(object sender, EventArgs e)
        {
            Trace.Listeners.Clear();
            string fileName = CheckFileDir("TraceOutput");
            Trace.Listeners.Add(new TextWriterTraceListener(fileName, "myListener"));
        }
        /// <summary>
        /// Trace is flushed. Information written to file.
        /// </summary>
        private void ProcessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Trace.Flush();
        }

        #region CheckBoxSortStatus 
        // IsSorted method is called within each of these event methods, the check to make sure the list is appropriately sorted updating the checkboxes.
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxSensorVisualA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
            checkBoxSensorVisualB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void checkBoxSensorA_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSensorVisualA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked;
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void checkBoxSensorB_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSensorVisualB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked;
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorProcessingA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorProcessingB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorVisualA_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualA.Checked = checkBoxSortProcessingA.Checked = checkBoxSensorA.Checked = IsSorted(sensorA);
        }
        /// <summary>
        /// Checks if the LinkedLists are sorted. Assigns resulting bool to checkBoxes
        /// </summary>
        private void listBoxSensorVisualB_MouseMove(object sender, EventArgs e)
        {
            checkBoxSensorVisualB.Checked = checkBoxSortProcessingB.Checked = checkBoxSensorB.Checked = IsSorted(sensorB);
        }



        #endregion

        #endregion




    }
}

