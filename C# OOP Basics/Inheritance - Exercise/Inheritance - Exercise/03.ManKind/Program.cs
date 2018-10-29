using System;

namespace ManKind
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            try
            {
                string[] studentInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string firstStudentName = studentInfo[0];
                string secondStudentName = studentInfo[1];
                string facultyNumber = studentInfo[2];
                Student student = new Student(firstStudentName, secondStudentName, facultyNumber);
                Console.WriteLine(student.ToString() + Environment.NewLine);

                string[] workerInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string workerFirstName = workerInfo[0];
                string workerSecondName = workerInfo[1];
                decimal weekSalary = decimal.Parse(workerInfo[2]);
                int hoursPerDay = int.Parse(workerInfo[3]);
                Worker worker = new Worker(workerFirstName, workerSecondName, weekSalary, hoursPerDay);
                Console.WriteLine(worker.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
