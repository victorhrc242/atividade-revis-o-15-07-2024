using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class animal
    {


        private string name;
        public int Idade { get; set; }
        private double peso;
        private double altura;

        public animal(string n, int n1, double i, double a)
        {
            name = n;
            Idade = n1;
            peso = a;
            altura = i;
        }

        public string Nome()
        {
            return name;
        }

        public double Peso()
        {
            return peso;
        }

        public double Altura()
        {
            return altura;
        }

        public void Come()
        {
            Console.WriteLine("Comendo");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormindo");
        }

        public virtual void Apresentar()
        {
            Console.WriteLine("Qual é o seu nome?");
            name = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            Idade = int.Parse(Console.ReadLine());
        }

        public virtual void RegistrarInformacoesAnimais()
        {

            Console.WriteLine("Qual é a sua altura?");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu peso?");
            peso = double.Parse(Console.ReadLine());
        }
    }
}

