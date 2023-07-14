/* WAP in C# Which can display avgrage marks */
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Rno = 1, Sub1 = 90, Sub2 = 35, total;
            double avg;
            string name = "Arjun";
            Console.WriteLine("Rno ="+Rno);
            Console.WriteLine("Sub1 =" + Sub1);
            Console.WriteLine("Sub2 =" +Sub2);
            total = Sub1 + Sub2;
            Console.WriteLine("total=" + total);
            avg = total / 2;
            if(avg>=75)
            {
                Console.WriteLine("Grade of student A");
            }
            else if (avg>60 && avg <= 75)
            {
                Console.WriteLine("Grade of student B");
            }
            else if (avg > 40 && avg <= 60)
            {
                Console.WriteLine("Grade of C");
            }
            else
            {
                Console.WriteLine("student is fail");
            }
        }   

    }
}