using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Salario

{
    internal class Program
    {
        
        static void Main(string[] args)
        {            
            double  salDia, salHora, salAno;
            //considerando jornada de 20 dias/mes e 8h por dia
            calcular();
                                   
        }

        //FUNÇOES
        public static void calcular()
        {
            double sal;
            Console.WriteLine("digite o salario do mes");
            sal = Convert.ToDouble(Console.ReadLine());
            carregando();

            Console.WriteLine("digite H para saber o salario por hora");
            Console.WriteLine("digite D para saber o salario por dia");
            Console.WriteLine("digite A para saber o salario por ano");

            switch (Console.ReadLine().ToUpper())
            {
                case "H": Console.WriteLine("o salario por hora é R$ " + hora(sal));
                    continuando();
                    break;

                case "D": Console.WriteLine("o salario por dia é R$ " + dia(sal));
                    continuando();
                    break;

                case "A": Console.WriteLine("o salario por ano é R$ " + ano(sal));
                    continuando();
                    break;
            }
        }
       public static double dia(double salMes)  => salMes / 20;
       
       public static double hora(double salMes) => salMes / (160);
        
       public static double ano(double salMes)  => salMes * 12;

        public static void carregando()
        {
            Console.WriteLine("\nloading...");
            Thread.Sleep(1000);
        }

        public static void continuando()
        {            
            Console.WriteLine("Você quer continuar com outro calculo? responda S ou N");
            string resp = Console.ReadLine().ToUpper();
            if (resp == "S") {
                Console.Clear();
                calcular(); } 
                                    
        }
   
    }
}
