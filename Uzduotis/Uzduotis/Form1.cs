using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzduotis
{
    public partial class Form1 : Form
    {
        private List<IntrestDate> intrestdate;
        private string folderPath = "";
        public Form1()
        {
            InitializeComponent();

            SetDateFormat();         
            intrestdate = new List<IntrestDate>();
            
        }
        //Setting the date fromat for visual purpose
        public void SetDateFormat()
        {
            dateSelectFrom.Format = DateTimePickerFormat.Custom;
            dateSelectFrom.CustomFormat = "yyyy MM dd";
            dateSelectTo.Format = DateTimePickerFormat.Custom;
            dateSelectTo.CustomFormat = "yyyy MM dd";
            intrestDateChangePicker.Format = DateTimePickerFormat.Custom;
            intrestDateChangePicker.CustomFormat = "yyyy MM dd";

            dateSelectTo.Value = DateTime.Now.Date;
            dateSelectFrom.Value = DateTime.Now.Date;
            intrestDateChangePicker.Value = DateTime.Now.Date;
        }
        //Calculates and creates CSV and fills it with data 
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dateSelectFrom.Value.Date;
            DateTime to = dateSelectTo.Value.Date;
            int diff = ((to.Year - from.Year) * 12) + to.Month - from.Month + 1;
            //Checking required input
            try
            {
                double moneyAmount = Convert.ToDouble(moneyAmmountTextBox.Text);
                double intrestRate = Convert.ToDouble(intrestRateTextBox.Text);
                //Annuity annuity = new Annuity();

                if(diff != 0 && moneyAmount > 0 && !folderPath.Equals("") && !fileNameTextBox.Text.Equals(""))
                {
                    csvGenerator csvgenerator = new csvGenerator(moneyAmount, intrestRate, from, to);
                    csvgenerator.Generate(folderPath + "\\" + fileNameTextBox.Text + ".csv", intrestdate);
                }
                else
                {
                    MessageBox.Show("Patikrinkite ivestus duomenis", "Ivedimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Patikrinkite ivestus duomenis", "Ivedimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exc);
                return;
            }
        }
        //Button to clear all data
        private void clearButton_Click(object sender, EventArgs e)
        {
            dateSelectTo.Value = DateTime.Now.Date;
            dateSelectFrom.Value = DateTime.Now.Date;
            intrestDateChangePicker.Value = DateTime.Now.Date;
            moneyAmmountTextBox.Clear();
            intrestRateTextBox.Clear();
            intrestChangeTextBox.Text = "";
            intrestDateChangePicker.Value = DateTime.Now.Date;
            fileNameTextBox.Text = "";
            folderLocationTextBox.Text = "";
            dateListBox.Items.Clear();
        }
        //Adds data about intrest rate change
        private void addIntrestChange_Click(object sender, EventArgs e)
        {  
            if(intrestChangeTextBox.Text != "")
            {
                try
                {
                    IntrestDate value = new IntrestDate(Convert.ToDouble(intrestChangeTextBox.Text), intrestDateChangePicker.Value.Date);
                    dateListBox.Items.Add(value.ToString());
                    intrestdate.Add(value);
                    Console.WriteLine("Size of" + intrestdate.Count);
                    intrestChangeTextBox.Text = "";
                    intrestDateChangePicker.Value = DateTime.Now.Date;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Palukanos ivestos blogai");
                    return;
                }

            }
        }
        //Removes data about intrest change
        private void removeIntrestChange_Click(object sender, EventArgs e)
        {
            foreach(IntrestDate value in intrestdate)
            {
                if(value.ToString().Equals(dateListBox.SelectedItem))
                {
                    intrestdate.RemoveAt(intrestdate.IndexOf(value));
                    dateListBox.Items.RemoveAt(dateListBox.SelectedIndex);
                    break;
                }
            }
        }
        //Selecting directory where to save the CSV file
        private void browseFileLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if(fdb.ShowDialog() == DialogResult.OK)
            {
                folderLocationTextBox.Text = fdb.SelectedPath;
                folderPath = fdb.SelectedPath;
            }
        }
    }
}
