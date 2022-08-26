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
           

            Console.WriteLine("digite H para saber o salario por hora");
            Console.WriteLine("digite D para saber o salario por dia");
            Console.WriteLine("digite A para saber o salario por ano");

            switch (Console.ReadLine().ToUpper())
{
                case "H":
                    Console.WriteLine("o salario por hora e: " + hora(sal) );                 
                    break;

                case "D":
                    Console.WriteLine("o salario por dia e: " + dia(sal) );                    
                    break;

                case "A":
                    Console.WriteLine("o salario por ano e: " + ano(sal) );                    
                    break;
            }
            Console.ReadLine();
            
        }
       public static double dia(double salMes)  => salMes / 20;
       
       public static double hora(double salMes) => salMes / (160);
        
       public static double ano(double salMes)  => salMes * 12;
   
    }
}
