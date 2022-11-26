using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace TautologySpoj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = new StringBuilder();
            Console.Write("Podaj T: ");
            //int T = int.Parse(Console.ReadLine());
            int T = 7;
            if (T <= 35)
            {
                for (int i = 0; i < T; i++)
                {
                    string variable = Console.ReadLine();
                    answer.AppendLine(Recurence(variable).ToString());
                }
                Console.WriteLine(answer.ToString());
            }
        }

        public static void Answer(int T)
        {
            Console.WriteLine(T);
            Operatory.C();
            Operatory.D();
            Operatory.E();
        }
        public static string Recurence(string variable)
        {

            return "YES";
        }
        public static void Chars(string var)
        {

        }


        
    }

}
