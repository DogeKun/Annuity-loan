using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis
{
    //This class is used for calculating annuity and outputting data
    class Annuity
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
        public double StartingMoney
        {
            get
            {
                return this.startingMoney;
            }
            set
            {
                this.startingMoney = value;
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
        public int Payments
        {
            get
            {
                return this.payments;
            }
            set
            {
                this.payments = value;
            }
        }

        private double moneyAmount;
        private double startingMoney;

        private double intrestRate;
        private double startingIntrestRate;
        private int payments;
        
        private double totalPayment;

        public Annuity (double moneyAmount, double startingMoney, double intrestRate, double startingIntrestRate, int payments)
        {
            this.moneyAmount = moneyAmount;            
            this.startingMoney = startingMoney;
            this.intrestRate = intrestRate / 100;
            this.payments = payments;
            this.startingIntrestRate = startingIntrestRate / 100;
        }

        public double getIntrestPayment()
        {
            return moneyAmount * (intrestRate / 12);
        }
        public double getPrincipalPayment()
        {
            return totalPayment - getIntrestPayment();
        }
        public double getTotalPayment()
        {
            double intrestpayment = startingMoney * (this.intrestRate / 12);
            double koeficient = (1 - Math.Pow(1 + (this.intrestRate / 12), (this.payments * (-1))));

            return totalPayment = (intrestpayment / koeficient);
        }
    }
}
