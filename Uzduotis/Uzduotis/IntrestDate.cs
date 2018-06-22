using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis
{
    //This class is used as a variable type to track intrest rate change
    class IntrestDate
    {
        public double IntrestRate
        {
            set
            {
                this.intrestRate = value;
            }
            get
            {
                return this.intrestRate;
            }
        }
        public DateTime ChangeDate
        {
            set
            {
                this.changeDate = value;
            }
            get
            {
                return this.changeDate;
            }
        }
        private double intrestRate;
        private DateTime changeDate;


        public IntrestDate(double intrestRate, DateTime changeDate)
        {
            this.intrestRate = intrestRate;
            this.changeDate = changeDate;
        }
        public override string ToString()
        {
            return changeDate.Date.ToString("yyy/MM/dd") + " " + intrestRate + "%";
        }
    }
}
