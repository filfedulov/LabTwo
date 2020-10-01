using System;


namespace SolutionName
{
    public class SolutionForLab
    {
        private const int Three = 3,
            K = 10;
        static private int changeToB = 1,  
            givenN;
        static private double x,
            valueSummForGivenN,
            valueSummForGivenE,
            changeFromA = 0.1,
            precisionE = 0.0001,
            amountSteps = (changeToB - changeFromA) / K,
            nextMember;


       public void SolutionTask()
        {
            for(x = changeFromA; x <= changeToB; x += amountSteps)
            {
                nextMember = 1.0;
                valueSummForGivenN = 1.0;
                for (givenN = 1; givenN < 10; givenN++)
                {
                    nextMember *= Math.Log(Three) * x / givenN;
                    valueSummForGivenN += nextMember;
                }

                givenN = 1;
                nextMember = 1.0;
                valueSummForGivenE = 1;
                do
                {
                    nextMember *= Math.Log(Three) * x / givenN;
                    valueSummForGivenE += nextMember;
                    givenN++;

                } while (nextMember > precisionE);

                Console.WriteLine($"X =  {x:F3};\tSN = {valueSummForGivenN:F3};\tSE = {valueSummForGivenE:F3};" +
                    $"\tY = {Math.Pow(Three, x):F3}.\n");

                valueSummForGivenN = 0;
                valueSummForGivenE = 0;
            }
        }
    }    
}
