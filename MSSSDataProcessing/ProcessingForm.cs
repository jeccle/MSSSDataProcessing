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
                
                int rangeIndex = index - (range / 2);
                double low, high, current;
                if (index - range < 0 || index + range > 400)
                {
                    // Find solution to error on first and last values.
                }
                low = double.Parse(listBox.Items[index - 1].ToString()) - valueRange;
                high = double.Parse(listBox.Items[index - 1].ToString()) + valueRange;
                listBox.SelectionMode = SelectionMode.MultiSimple;
                Trace.TraceInformation("Selecting multiple values - Index range value: " + range + " Deviation: " + valueRange);
                for (int i = 0; i < range && rangeIndex < 400; i++)
                {
                    current = double.Parse(listBox.Items[rangeIndex].ToString());
                    Trace.WriteLine("Comparing " + current + " to " + low + " && " + current + " to " + high);
                    if (current > low && current < high)
                    {
                        listBox.SetSelected(rangeIndex, true);
                        Trace.TraceInformation(current + " SELECTED in listBox");
                    }
                    rangeIndex++;
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
                if (searchValue == sensor.ElementAt(mid))
                    return mid;
                else if (searchValue > sensor.ElementAt(mid))
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return min;
        }

        private int RecursiveBinarySearch(LinkedList<double> sensor, double searchValue, int min, int max)
        {
            while (min <= max - 1)
            {
                int mid = (min + max) / 2;
                if (searchValue == sensor.ElementAt(mid))
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
            int sortNum = RadioButtonIndex("SortA");
            if (sortNum == 1)
            {
                sortedA = SelectionSort(sensorA);
                ShowAllSensorData();
                PopulateListBox(sensorA, listBoxA);
                statusLabel.Text = "Sensor A has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                sortedA = InsertionSort(sensorA);
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
            int sortNum = RadioButtonIndex("SortB");
            if (sortNum == 1)
            {
                sortedB = SelectionSort(sensorB);
                ShowAllSensorData();
                PopulateListBox(sensorB, listBoxB);
                statusLabel.Text = "Sensor B has been sorted using Selection Sort.";
            }
            else if (sortNum == 0)
            {
                sortedB = InsertionSort(sensorB);
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
                double searchValue = IntOrDouble(TbTargetA.Text);
                int searchNum = RadioButtonIndex("SearchA");
                if (searchNum == 1)
                {
                    int foundIndex = IterativeBinarySearch(sensorA, searchValue);
                    // First int is mid index, second int is the range of values to be checked.
                    // Third int is the value range difference.
                    ListBoxSetSelected(listBoxA, foundIndex, 5, 1);
                }
                else if (searchNum == 0)
                {
                    int foundIndex = RecursiveBinarySearch(sensorA, searchValue, 0, NumberOfNodes(sensorA));
                    ListBoxSetSelected(listBoxA, foundIndex, 5, 1);
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
            if (CheckInput(TbTargetB.Text, TbTargetB) && sortedB)
            {
                double searchValue = IntOrDouble(TbTargetB.Text);
                int searchNum = RadioButtonIndex("SearchB");
                if (searchNum == 1)
                {
                    int foundIndex = IterativeBinarySearch(sensorB, searchValue);
                    ListBoxSetSelected(listBoxB, foundIndex, 5, 1);
                }
                else if (searchNum == 0)
                {
                    int foundIndex = RecursiveBinarySearch(sensorB, searchValue, 0, NumberOfNodes(sensorB));
                    ListBoxSetSelected(listBoxB, foundIndex, 5, 1);
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

