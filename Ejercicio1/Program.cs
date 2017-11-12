using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            double salario, bono, SalarioT;

            //se solicita al usuario ingresar un salario
            Console.Write("Ingrese el salario del empleado: ");

            //Leer el salario ingresado
            salario = double.Parse(Console.ReadLine());

            //condicion si el salario es mayor o igual que 100 y salario menor o igual que 200
            if(salario >= 100 && salario <= 200)
            {
                //Calculo del bono multiplicando el salario por el 10%
                bono = salario * 0.1;
                //Calculo de salario total sumando el salario inicial mas el bono
                SalarioT = salario + bono;
                //Mostrar resultados al usuario
                Console.WriteLine("El bono es del 10%");
                Console.WriteLine("El monto del bono es: "+ "$"+ bono);
                Console.WriteLine("El salario total es: " + "$" + SalarioT);
            }
            else
                if(salario > 20 && salario <= 300)
            {
                bono = salario * 0.2;
                SalarioT = salario + bono;
                Console.WriteLine("El bono es del 20%");
                Console.WriteLine("El monto del bono es: " + bono);
                Console.WriteLine("El salario total es: " + SalarioT);
            }
            else
                if(salario > 300)
            {
                bono = salario * 0.3;
                SalarioT = salario + bono;
                Console.WriteLine("El bono es del 30%");
                Console.WriteLine("El monto del bono es: " + bono);
                Console.WriteLine("El salario total es: " + SalarioT);
            }
            Console.ReadKey();
        }
    }
}
