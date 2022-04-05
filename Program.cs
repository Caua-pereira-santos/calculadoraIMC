using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? Ex. 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg? Ex: 70,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0} sua altura é {1} e seu peso {2}", nome, altura, peso);
            Console.WriteLine("Seu IMC é {0}", imc);

            if (imc <=17.00)

            {
                Console.WriteLine("Muito abaixo do peso");
            }

            else if (imc >=17.00 && imc <18.50)

            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (imc >=18.50 && imc <25.00)

            {
                Console.WriteLine("Peso normal");
            }

            else if (imc >=25.00 && imc <30.00)

            {
                Console.WriteLine("Acima do peso");
            }

            else if (imc >=30.00 && imc <35.00)

            {
                Console.WriteLine("Obesidade I");
            }

            else if (imc >=35.00 && imc <40.00)

            {
                Console.WriteLine("Obesidade II (Severa)");
            }

            else

            {
                Console.WriteLine("Obesidade III (Mórbida)");
            }

            if (altura >=150 && altura <160)

            {
                Console.WriteLine("O seu peso ideal está entre 51.3 a 72.3");
            }

            else if (altura >=160 && altura <170)

            {
                Console.WriteLine("O seu peso ideal está entre 59.8 a 81.0");
            }

            
            else if (altura >=170 && altura <180)

            {
                Console.WriteLine("O seu peso ideal está entre 72.7 a 89.9");
            }

            else if (altura >=180 && altura <190)

            {
                Console.WriteLine("O seu peso ideal está entre 89.9 a 100.7");
            }

           




        }
    }
}
