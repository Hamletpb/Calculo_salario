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
        public static  double salario, salDia, salHora, salAno;
        public static  string nome; 
        public static int horas;

        static void Main(string[] args)
        {                    

            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();

            Console.WriteLine("\ndigite o salario do mes");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\ndigite a carga horaria");
            horas = Convert.ToInt32(Console.ReadLine());

            
            calcular(nome,salario,horas);
            

        }

        //FUNÇOES
        public static void calcular(string nom, double sal, int hrs)
        {        
                   
            carregar();

            Console.WriteLine("\ndigite H para saber o salario por hora");
            Console.WriteLine("digite D para saber o salario por dia");
            Console.WriteLine("digite A para saber o salario por ano\n");

            switch (Console.ReadLine().ToUpper())
            {
                case "H": Console.WriteLine($"{nom}, seu salario por hora é R$ " + hora(sal,hrs));
                    continuar();
                    break;

                case "D": Console.WriteLine($"{nom}, o salario por dia é R$ " + dia(sal));
                    continuar();
                    break;

                case "A": Console.WriteLine($"{nom}, o salario por ano é R$ " + ano(sal));
                    continuar();
                    break;
            }
        }
       public static double dia(double salMes)  => salMes / 20;
       
       public static double hora(double salMes, int hr) => salMes / (hr);
        
       public static double ano(double salMes)  => salMes * 12;

        public static void carregar()
        {
            Console.WriteLine("\nloading...");
            Thread.Sleep(1000);
        }

        public static void continuar()
        {            
            Console.WriteLine("Você quer continuar com outro calculo? responda S ou N");
            string resp = Console.ReadLine().ToUpper();
            if (resp == "S") {
                Console.Clear();
                calcular(nome,salario, horas); } 
                                    
        }
   

    }
}
