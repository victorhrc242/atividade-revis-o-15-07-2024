using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class cachorro:animal
    {
        private string raca { get; set; }
        public cachorro(string r,string n, int i,double p,double a) : base(n, i,p,a)
        {
            
        }

      
        

        public void latir()
        {
            Console.WriteLine("latindo");
        }
        public override void apresentar()
        {
            Console.WriteLine("qual o seu nome?");
            name = Console.ReadLine();
            Console.WriteLine("qual a sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("qual a sua raça");
            raca = Console.ReadLine();
        }
    }
}
