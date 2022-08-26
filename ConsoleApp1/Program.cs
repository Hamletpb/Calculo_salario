using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, salDia, salHora, salAno;
            //considerando jornada de 20 dias/mes e 8h por dia

            Console.WriteLine("digite o salario do mes");
            sal =  Convert.ToDouble(Console.ReadLine());
           

            Console.WriteLine("digite H para o salario por hora");
            Console.WriteLine("digite D para o salario por dia");
            Console.WriteLine("digite A para o salario por ano");

            switch (Console.ReadLine())
{
                case "H":
                    Console.WriteLine("o salario por hora e: " + hora(sal) );
                    // código 1
                    break;
                case "D":
                    Console.WriteLine("o salario por dia e: " + dia(sal) );
                    // código 2
                    break;

                case "A":
                    Console.WriteLine("o salario por ano e: " + ano(sal) );
                    // código 4
                    break;
            }

            Console.ReadLine();
            
        }
       public static double dia(double salMes)
        {
            return salMes / 20;
        }

       public static double hora(double salMes)
        {
            return salMes / (8 * 20);
        }

       public static double ano(double salMes)
        {
            return salMes * 12;
        }
    }
}
