using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Windows.Forms;

namespace Uzduotis
{
    //This class is used for creating CSV file
    //Annuity is used for calculating data and putting it to StringBuilder later to put it into CSV file
    class csvGenerator
    {
        public double MoneyAmount
        {
            get
            {
                return this.moneyAmount;
            }
            set
            {
                this.moneyAmount = value;
            }
        }
        public double IntrestRate
        {
            get
            {
                return this.intrestRate;
            }
            set
            {
                this.intrestRate = value;
            }
        }
        public DateTime From {
            get
            {
                return from;
            }
            set
            {
                this.from = value;
            }
        }
        public DateTime To
        {
            get
            {
                return to;
            }
            set
            {
                this.to = value;
            }
        }

        private double moneyAmount;
        private double intrestRate;
        private DateTime from;
        private DateTime to;


        public csvGenerator(double moneyAmount, double intrestRate, DateTime from, DateTime to)
        {
            this.moneyAmount = moneyAmount;
            this.intrestRate = intrestRate;
            this.from = from;
            this.to = to;
        }
        public void Generate(string filePath, List<IntrestDate> intrestdate)
        {
            //Creating String builder
            StringBuilder buildString = new StringBuilder();
            
            //Setting a seperator to be a comma
            buildString.AppendLine("sep=,");
            //Adding data types
            string newline = "Payment #,Payment date,Remaining ammount,Principal payment,Intrest payment, Total payment, Intrestrate";
            buildString.AppendLine(newline);

            int diff = ((to.Year - from.Year) * 12) + to.Month - from.Month + 1;

            double remainingMoney = moneyAmount;
            double currentIntrest = intrestRate;
            DateTime currentDate = this.from;
            double totalPayment = 0;
            int payments = diff;

            List<IntrestDate> currentIntrestDate = intrestdate.ToList();
            Annuity annuity;
            
            for(int i = 1; i <= diff; i++)
            {
                //Checking if there is intrest rate change and changes it when need arises
                if(intrestdate.Count != 0)
                {
                    foreach(IntrestDate value in currentIntrestDate)
                    {
                        if(currentDate.Date >= value.ChangeDate.Date)
                        {
                            moneyAmount = remainingMoney;
                            currentIntrest = value.IntrestRate;
                            currentIntrestDate.RemoveAt(currentIntrestDate.IndexOf(value));
                            payments = (diff + 1) - i;
                            break;
                        }
                    }
                }
                //Starts annuity calculation
                annuity = new Annuity(remainingMoney, moneyAmount, currentIntrest, intrestRate, payments);
                //Outputing data 
                totalPayment = annuity.getTotalPayment();
                //Replacing decimal commas
                string RemainingMoney = Math.Round(remainingMoney, 2, MidpointRounding.ToEven).ToString();
                RemainingMoney = RemainingMoney.Replace(",", ".");
                string PrincipalPayment = Math.Round(annuity.getPrincipalPayment(), 2, MidpointRounding.ToEven).ToString();
                PrincipalPayment = PrincipalPayment.Replace(",", ".");
                string IntrestPayment = Math.Round(annuity.getIntrestPayment(), 2, MidpointRounding.ToEven).ToString();
                IntrestPayment = IntrestPayment.Replace(",", ".");
                string TotalPayment = Math.Round(totalPayment, 2, MidpointRounding.ToEven).ToString();
                TotalPayment = TotalPayment.Replace(",", ".");
                string CurrentIntrest = Math.Round(currentIntrest, 2, MidpointRounding.ToEven).ToString();
                CurrentIntrest = CurrentIntrest.Replace(",", ".");

                //Console.WriteLine(TotalPayment + " " + Math.Round(totalPayment, 2));

                //Creates a string to put into a string builder
                newline = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                    i, currentDate.Date.ToString("yyy/MM/dd"), RemainingMoney, PrincipalPayment, IntrestPayment, TotalPayment, CurrentIntrest);

                //Console.WriteLine(newline);
                //Adds newline with data into string builder
                buildString.AppendLine(newline);
                //Subtracts already paid amount of money
                //And adds a month to indicate that it is already paid
                //Also months indicate possible intrest change
                remainingMoney -= annuity.getPrincipalPayment();
                currentDate = currentDate.AddMonths(1);
            }
            //Creates a CSV file and outputs data into it
            try
            {
                using (StreamWriter swriter = new StreamWriter(filePath))
                {
                    swriter.Write(buildString.ToString());
                }
            } 
            catch (Exception exc)
            {
                MessageBox.Show("Failas kuri norite irasyti \njau aegzistuoja ir atidarytas", "Irasymas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
