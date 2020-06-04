using System;

namespace Aula10_Sprint4_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Mario : ");
            System.Console.WriteLine();
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();
            mario.Cair();
            System.Console.WriteLine();

            System.Console.WriteLine("Luigi : ");
            System.Console.WriteLine();
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
            luigi.Cair();
            System.Console.WriteLine();


            System.Console.WriteLine("Peach : ");
            System.Console.WriteLine();
            Peach peach = new Peach();
            peach.Correr();
            peach.Pular();
            peach.Cair();
            System.Console.WriteLine();
        }
    }
}
