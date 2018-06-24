using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelectionSortForm : Form
    {
        public SelectionSortForm()
        {
            InitializeComponent();
        }

        List<double> unsortedList = new List<double>();

        #region Event Handlers

        #region Enter Button
        private void enterButton_Click(object sender, EventArgs e)
        {
            numTextBox.SelectAll();
            double number;
            bool isNumber = double.TryParse(numTextBox.Text, out number);

            if (isNumber)
            {
                numListBox.Items.Add(number);
                unsortedList.Add(number);

                numListBox.ClearSelected();
                meanLabel.Text = "Mean: ";
                medianLabel.Text = "Median: ";
                modeLabel.Text = "Mode: ";
            }
            else
            {
                MessageBox.Show("Are you okay?", "That's not a number!", MessageBoxButtons.YesNoCancel);
            }
        }
        #endregion

        #region Number TextBox
        private void numTextBox_Click(object sender, EventArgs e)
        {
            numTextBox.SelectAll();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            numListBox.Items.Clear();
            unsortedList.Clear();
            numTextBox.Clear();

            meanLabel.Text = "Mean: ";
            medianLabel.Text = "Median: ";
            modeLabel.Text = "Mode: ";
        }
        #endregion

        #region Minimum Button
        private void minButton_Click(object sender, EventArgs e)
        {
            if (numListBox.Items.Count > 0)
            {
                numListBox.ClearSelected();
                numListBox.SetSelected(numListBox.Items.IndexOf(Minimum(unsortedList)), true);
            }
        }
        #endregion

        #region Maximum Button
        private void maxButton_Click(object sender, EventArgs e)
        {
            if (numListBox.Items.Count > 0)
            {
                numListBox.ClearSelected();
                numListBox.SetSelected(numListBox.Items.IndexOf(Maximum(unsortedList)), true);
            }
        }
        #endregion

        #region Sort Button
        private void sortButton_Click(object sender, EventArgs e)
        {
            numListBox.Items.Clear();
            List<double> sortedList = new List<double>(Sort(unsortedList));
            foreach (double num in sortedList)
            {
                numListBox.Items.Add(num);
            }
        }
        #endregion

        #region Mean Button
        private void meanButton_Click(object sender, EventArgs e)
        {
            if (numListBox.Items.Count > 0)
            {
                numListBox.ClearSelected();
                meanLabel.Text = "Mean: " + Mean(unsortedList);
            }
        }
        #endregion

        #region Median Button
        private void medianButton_Click(object sender, EventArgs e)
        {
            if (numListBox.Items.Count > 0)
            {
                numListBox.ClearSelected();
                medianLabel.Text = "Median: " + Median(unsortedList);
            }
        }
        #endregion

        #region Mode Button
        private void modeButton_Click(object sender, EventArgs e)
        {
            if (numListBox.Items.Count > 0)
            {
                numListBox.ClearSelected();
                modeLabel.Text = "Mode: " + String.Join(", ", Mode(unsortedList));
            }
        }
        #endregion

        #region Scramble Button
        private void scrambleButton_Click_1(object sender, EventArgs e)
        {
            numListBox.Items.Clear();
            List<double> scrambleList = new List<double>(Scramble(unsortedList));
            foreach (double num in scrambleList)
            {
                numListBox.Items.Add(num);
            }
        }
        #endregion

        #endregion

        #region Procedures

        #region Minimum
        private double Minimum(List<double> list)
        {
            double min = list[0];
            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    double num = list[i];
                    if (num < min)
                    {
                        min = num;
                    }
                }
            }

            return min;
        }
        #endregion

        #region Maximum
        private double Maximum(List<double> list)
        {
            double max = list[0];
            if (list.Count > 1)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    double num = list[i];
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }

            return max;
        }
        #endregion

        #region Sort
        private List<double> Sort(List<double> list)
        {
            List<double> copyOfList = new List<double>(list);
            List<double> sortedList = new List<double>();

            bool ascending = ascendingRadioButton.Checked;

            for (int i = 0; i < list.Count; i++)
            {
                double minOrMax = ascending ? Minimum(copyOfList) : Maximum(copyOfList);
                sortedList.Add(minOrMax);
                copyOfList.Remove(minOrMax);
            }

            return sortedList;
        }
        #endregion

        #region Mean
        private double Mean(List<double> list)
        {
            double sum = 0;
            foreach (double num in list)
            {
                sum += num;
            }

            return sum / list.Count;
        }
        #endregion

        #region Median
        private double Median(List<double> list)
        {
            List<double> sortedList = new List<double>(Sort(unsortedList));
            int count = sortedList.Count;
            double median = (count % 2 == 0) ? (sortedList[count / 2 - 1] + sortedList[count / 2]) / 2 : sortedList[count / 2];

            return median;
        }
        #endregion

        #region Mode
        private List<double> Mode(List<double> list)
        {
            double frequency = 1;
            double num;
            double modeFrequency;

            List<double> numList = new List<double>();
            List<double> frequencyList = new List<double>();
            List<double> sortedList = new List<double>(Sort(list));
            List<double> modeList = new List<double>();

            num = sortedList[0];

            if (list.Count > 0)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    if (sortedList[i] == num)
                    {
                        frequency++;
                    }
                    else
                    {
                        numList.Add(num);
                        frequencyList.Add(frequency);
                        num = sortedList[i];
                        frequency = 1;
                    }
                }

                // Have reached the end of the list
                numList.Add(num);
                frequencyList.Add(frequency);
            }

            modeFrequency = Maximum(frequencyList);
            while (frequencyList.Contains(modeFrequency))
            {
                double mode = numList[frequencyList.IndexOf(modeFrequency)];
                modeList.Add(mode);
                numList.Remove(mode);
                frequencyList.Remove(modeFrequency);
            }

            return modeList;
        }
        #endregion

        #region Scramble
        private List<double> Scramble(List<double> list)
        {
            Random rnd = new Random();
            List<double> copyOfList = new List<double>(list);
            List<double> scrambleList = new List<double>();

            for (int i = 0; i < list.Count; i++)
            {
                double num = copyOfList[rnd.Next(copyOfList.Count)];
                scrambleList.Add(num);
                copyOfList.Remove(num);
            }

            return scrambleList;
        }
        #endregion

        #endregion

    }
}
