using System;
using SolutionName;



namespace MainName
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SolutionForLab objectSFL = new SolutionForLab();
                objectSFL.SolutionTask();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
