using System;
using System.Security.Cryptography.X509Certificates;

namespace SolutionName
{
    public class SolutionForLab
    {
        private const int Three = 3,
            K = 10;
        static private int changeToB = 1,  
            givenN = 0;
        static private double xAxis,
            valueSummForGivenN,
            valueSummForGivenE,
            changeFromA = 0.1,
            precisionE = 0.0001,
            amountSteps = (changeToB - changeFromA) / K,
            checkPrecisionAndSummForVLSFE;


        private int Factorial(int givenN)
        {
            if (givenN == 0 || givenN == 1)
                return 1;

            return givenN * Factorial(givenN - 1);
        }

        private double SummRow(int givenN, double xAxis)
        {
            double numeratorOfCommonMember = Math.Pow(Math.Log(Three), givenN);
            double denominatorOfCommonMember = Factorial(givenN);
            double multiplierOfCommonMember = Math.Pow(xAxis, givenN);

            return (numeratorOfCommonMember / denominatorOfCommonMember) * multiplierOfCommonMember;
        }
       
        public void SolutionTask()
        {
            for(xAxis = changeFromA; xAxis <= changeToB; xAxis += amountSteps)
            {
                for (givenN = 0; givenN <= 10; givenN++)
                {
                    valueSummForGivenN += SummRow(givenN, xAxis);
                }

                givenN = 0;

                do
                {
                    checkPrecisionAndSummForVLSFE = SummRow(givenN, xAxis);
                    valueSummForGivenE += checkPrecisionAndSummForVLSFE;
                    givenN++;

                } while (checkPrecisionAndSummForVLSFE > precisionE);
                
                Console.WriteLine($"X =  {xAxis:F3};\tSN = {valueSummForGivenN:F3};\tSE = {valueSummForGivenE:F3};" +
                    $"\tY = {Math.Pow(Three, xAxis):F3}.\n");

                valueSummForGivenN = 0;
                valueSummForGivenE = 0;
            }
        }

        public void Tmp()
        {
            Console.WriteLine();
            for (xAxis = changeFromA; xAxis <= changeToB; xAxis += amountSteps)
            {
                valueSummForGivenN = 1;
                for (givenN = 0; givenN < 10; givenN++)
                {
                    valueSummForGivenN += Math.Log(3) / (givenN * givenN + 1) * Math.Pow(xAxis,givenN + 1);
                }

                givenN = 0;

                do
                {
                    checkPrecisionAndSummForVLSFE = SummRow(givenN, xAxis);
                    valueSummForGivenE += checkPrecisionAndSummForVLSFE;
                    givenN++;

                } while (checkPrecisionAndSummForVLSFE > precisionE);

                Console.WriteLine($"X =  {xAxis:F3};\tSN = {valueSummForGivenN:F3};\tSE = {valueSummForGivenE:F3};" +
                    $"\tY = {Math.Pow(Three, xAxis):F3}.\n");

                valueSummForGivenN = 0;
                valueSummForGivenE = 0;
            }
        }
    }    
}
