using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            for (int i = 0; i < 400; i++)
            {
                sensorA.AddFirst(satellite.SensorA((double)MeanNumWheel.Value, (double)SigmaNumWheel.Value));
                sensorB.AddFirst(satellite.SensorB((double)MeanNumWheel.Value, (double)SigmaNumWheel.Value));
                Trace.WriteLine("Adding " + sensorA.First.Value + " to sensorA LinkedList.");
                Trace.WriteLine("Adding " + sensorB.First.Value.ToString() + " to sensorB LinkedList.");
            }
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
                Trace.WriteLine("Adding SensA " + sensorAEnum.Current.ToString() + " & SensB " + sensorBEnum.Current.ToString());
            }
            Trace.TraceInformation("List view populated.");

        }

        #endregion

        #region Utility Methods

        private int NumberOfNodes(LinkedList<double> sensor)
        {
            return sensor.Count;
        }
        private void PopulateListBox(LinkedList<double> sensor, ListBox listBox)
        {
            listBox.Items.Clear();
            LinkedList<double>.Enumerator sensorEnum = sensor.GetEnumerator();
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
                    if (radioSelectionA.Checked) { index = 1; break; }
                    else if (radioInsertionA.Checked) { index = 0; break; }
                    else { index = -1; break; }

                case "SEARCHA":
                    if (radioIterativeA.Checked) { index = 1; break; }
                    else if (radioRecursiveA.Checked) { index = 0; break; }
                    else { index = -1; break; }

                case "SORTB":
                    if (radioSelectionB.Checked) { index = 1; break; }
                    else if (radioInsertionB.Checked) { index = 0; break; }
                    else { index = -1; break; }

                case "SEARCHB":
                    if (radioIterativeB.Checked) { index = 1; break; }
                    else if (radioRecursiveB.Checked) { index = 0; break; }
                    else { index = -1; break; }
            }
            return index;
        }
        private bool CheckInput(string TbInput, TextBox TbTarget)
        {
            if (string.IsNullOrEmpty(TbInput))
            {
                TbTarget.Focus();
                toolTip.Show("Please enter appropriate decimal value", TbTarget, 60, 15, 3000);
                return false;
            }
            else
                return true;

        }

        // First int is mid index, second int is the range of values to be checked.
        // Third int is the value range difference.
        private void ListBoxSetSelected(ListBox listBox, int index, int range, double valueRange)
        {
            try
            {
                listBox.SelectedItems.Clear();
                // pointerIndex variable holds index of first item in the range of values to be checked.
                // If the search index is 3, with a range of 6, the starting pointerIndex value will be 0.
                
                int pointerIndex = index - range / 2;
                if (pointerIndex < 0)
                {
                    // Sets starting index to 0, range is reduced to compensate for non-existent values.
                    range += pointerIndex;
                    pointerIndex = 0; 
                }
                double low, high, current;
                // Boundaries for selection of values within listBox.
                low = double.Parse(listBox.Items[index].ToString()) - valueRange;
                high = double.Parse(listBox.Items[index].ToString()) + valueRange;
                Trace.TraceInformation("Selecting multiple values - Index range value: " + range + " Deviation: " + valueRange);
                // pointerIndex value is incremented untill i >= range value. Loop checks if current value meets criteria for selection.
                for (int i = 0; i < range && pointerIndex < 400; i++)
                { 
                    current = double.Parse(listBox.Items[pointerIndex].ToString());
                    Trace.WriteLine("Comparing " + current + " to " + low + " && " + current + " to " + high + " -- Deviation of " + valueRange);
                    // If current value is within upper and lower bounds.
                    if (current > low && current < high)
                    {
                        // Code highlights index.
                        listBox.SetSelected(pointerIndex, true);
                        Trace.TraceInformation(current + " SELECTED in listBox");
                    }
                    pointerIndex++;
                }
            }
            catch (IndexOutOfRangeException)
            {
                Trace.TraceError("Index is out of array.");
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
            int min = 0;
            int max = NumberOfNodes(sensor);
            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {
                    if (sensor.ElementAt(min) < sensor.ElementAt(j))
                        min = j;
                }
                LinkedListNode<double> currentMin = sensor.Find(sensor.ElementAt(min));
                LinkedListNode<double> currentI = sensor.Find(sensor.ElementAt(i));
                Trace.WriteLine("Current Min Value " + currentMin.Value + " | Current I Value " + currentI.Value);
                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
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
                        var temp = current.Value;
                        current.Value = currentLeft.Value;
                        currentLeft.Value = temp;
                    }
                }
            }
            return true;
        }

        private int IterativeBinarySearch(LinkedList<double> sensor, double searchValue)
        {
            int min = 0;
            int max = NumberOfNodes(sensor);
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                // Find an exact value or if searchValue is an int, it can be matched with a casted int for a more general search.
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid)) 
                    return mid;
                else if (searchValue < sensor.ElementAt(mid))
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            return min;
        }

        private int RecursiveBinarySearch(LinkedList<double> sensor, double searchValue, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                // Find an exact value or if searchValue is an int, it can be matched with a casted int for a more general search.
                if (searchValue == sensor.ElementAt(mid) || searchValue == (int)sensor.ElementAt(mid))
                    return mid;
                else if (searchValue > sensor.ElementAt(mid))
                    return RecursiveBinarySearch(sensor, searchValue, min, mid - 1);
                else
                    return RecursiveBinarySearch(sensor, searchValue, mid + 1, max);
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
                sw.Start();
                // Bool allows search algorithms to be used once set to true.
                sortedA = SelectionSort(sensorA);
                sw.Stop();
                TbSortSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorA, listBoxA);
                statusLabel.Text = "Sensor A has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                sw.Start();
                sortedA = InsertionSort(sensorA);
                sw.Stop();
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
                sw.Start();
                // Bool allows search algorithms to be used once set to true.
                sortedB = SelectionSort(sensorB);
                sw.Stop();
                TbSortSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                ShowAllSensorData();
                PopulateListBox(sensorB, listBoxB);
                statusLabel.Text = "Sensor B has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                sw.Start();
                sortedB = InsertionSort(sensorB);
                sw.Stop();
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
                    sw.Start();
                    int foundIndex = IterativeBinarySearch(sensorA, searchValue);
                    sw.Stop();
                    TbSearchSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    // First int is mid index, second int is the range of values to be checked.
                    // Third int is the value range difference.
                    ListBoxSetSelected(listBoxA, foundIndex, 6, 1);
                }
                else if (searchNum == 0)
                {
                    sw.Start();
                    int foundIndex = RecursiveBinarySearch(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                    sw.Stop();
                    TbSearchSpdA.Text = sw.Elapsed.TotalMilliseconds.ToString(); 
                    ListBoxSetSelected(listBoxA, foundIndex, 6, 1);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeA, 65, 20, 3000);
            }
            else
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
                    sw.Start();
                    int foundIndex = IterativeBinarySearch(sensorB, searchValue);
                    sw.Stop();
                    TbSearchSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    ListBoxSetSelected(listBoxB, foundIndex, 6, 1);
                }
                else if (searchNum == 0)
                {
                    sw.Start();
                    int foundIndex = RecursiveBinarySearch(sensorB, searchValue, 0, NumberOfNodes(sensorB));
                    sw.Stop();
                    TbSearchSpdB.Text = sw.Elapsed.TotalMilliseconds.ToString();
                    ListBoxSetSelected(listBoxB, foundIndex, 6, 1);
                }
                else
                    toolTip.Show("Select a search algorithm", radioIterativeB, 65, 20, 3000);
            }
            else
            {
                toolTip.Show("Ensure ListBox is Sorted!", buttonSortB, 45, 15, 3000);
                statusLabel.Text = "Sensor B values not sorted. Cannot search";
            }
        }

        #endregion

    }
}

