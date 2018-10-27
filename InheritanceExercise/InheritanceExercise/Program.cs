using System;

namespace InherterenceExercise
{
  public  class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var workerInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(studentInfo[0],studentInfo[1],studentInfo[2]);
                Console.WriteLine(student);
                Console.WriteLine();
                var worker = new Worker(workerInfo[0],workerInfo[1],decimal.Parse(workerInfo[2]),decimal.Parse(workerInfo[3]));
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }


        }
    }
}
