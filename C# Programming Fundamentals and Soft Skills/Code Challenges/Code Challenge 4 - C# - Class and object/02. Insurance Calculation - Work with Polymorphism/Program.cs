using System;

namespace Insurance_Calculation_Work_with_Polymorphism      //DO NOT CHANGE namespace name
{ 
    public class Program       //DO NOT CHANGE class 'Program' name
    {
        public static void Main(string[] args)
        {
            //Implement code here
            Program p = new Program();
            LifeInsurance li = new LifeInsurance();
            MotorInsurance mi = new MotorInsurance();

            Console.WriteLine("Insurance Number :");
            li.InsuranceNo = mi.InsuranceNo = Console.ReadLine();

            Console.WriteLine("Insurance Name :");
            li.InsuranceName = mi.InsuranceName = Console.ReadLine();

            Console.WriteLine("Amount Covered :");
            li.AmountCovered = mi.AmountCovered = double.Parse(Console.ReadLine());

            Console.WriteLine("Select");
            Console.WriteLine("1. Life Insurance");
            Console.WriteLine("2. Motor Insurance");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Policy Term :");
                li.PolicyTerm = int.Parse(Console.ReadLine());

                Console.Write("Benefit Percent :");
                li.BenefitPercent = int.Parse(Console.ReadLine());

                Console.Write($"Calculated Premium : {p.addPolicy(li, option)}");
            }
            else if (option == 2)
            {
                Console.WriteLine("Dep Percent");
                mi.DepPercent = float.Parse(Console.ReadLine());

                Console.WriteLine($"Calculated Premium : {p.addPolicy(mi, option)}");
            }
        }

        //Implement Methods here
        public double addPolicy(Insurance ins, int opt)
        {
            //Implement code here
            if (opt == 1)
            {
                LifeInsurance l = (LifeInsurance)ins;
                return l.calculatePremium();
            }
            else
            {
                MotorInsurance m = (MotorInsurance)ins;
                return m.calculatePremium();
            }
        }
    }
}
