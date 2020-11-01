using System;
using System.Collections.Generic;
using System.Text;

namespace Insurance_Calculation_Work_with_Polymorphism      //DO NOT CHANGE namespace name
{
    //Implement the code here. Keep the class 'public'
    public class Insurance
    {
        private string insuranceNo;
        private string insuranceName;
        private double amountCovered;

        public string InsuranceNo { get; set; }
        public string InsuranceName { get; set; }
        public double AmountCovered { get; set; }
    }

    class MotorInsurance : Insurance
    {
        private double idv;
        private float depPercent;

        public double Idv { get; set;}
        public float DepPercent { get; set; }

        public double calculatePremium()
        {
            Idv = AmountCovered - ((AmountCovered * DepPercent) / 100);
            return (Idv * 0.03);
        }
    }

    class LifeInsurance : Insurance
    {
        private int policyTerm;
        private float benefitPercent;
        
        public int PolicyTerm { get; set; }
        public float BenefitPercent { get; set; }

        public double calculatePremium()
        {
            return (AmountCovered - ((AmountCovered * BenefitPercent) / 100)) / PolicyTerm;
        }
    }
}
