using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class gato:animal
    {
        public gato( string n, int i,double p,double a) : base(n,i,p,a)
        {
            
        }
        public void miar()
        {
            Console.WriteLine("Miau");
        }
        public override void apresentar()
        {

        }
        public override void registrarinformaçoesAnimais()
        {
            Console.WriteLine(" qual o seu nome?");
            name = Console.ReadLine();
            Console.WriteLine("qual a sua idade");
            idade=int.Parse(Console.ReadLine());
            Console.WriteLine("quantos pesa");
            pesos = int.Parse(Console.ReadLine());
            Console.WriteLine("qual a altura");
            altura=int.Parse(Console.ReadLine());
            
        }
    }
}
