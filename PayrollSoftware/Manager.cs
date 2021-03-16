using System;

namespace PayrollSoftware
{
    class Manager : Staff
    {
        public Manager(string name) : base (name, managerHourlyRate)
        {

        }
        private const float managerHourlyRate = 50;
        public int Allowance { get; private set; }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;
            if (HoursWorked > 160)
            {
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nmanagerHourlyRate = " + managerHourlyRate + "\nHoursWorked = " + HoursWorked +"\nBasicPay = " + BasicPay + "\nAllowance = " + Allowance + "\nTotalPay = " + TotalPay;
        }

    }
}
