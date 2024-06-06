using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Program
{
    static void Main(string[] args)
    {
        Jogo jogo = new Jogo();

        Console.WriteLine(jogo.exibirMapa());

        /*Thread.CurrentThread.Name = "Bola";

        Thread t1 = new Thread(new ThreadStart(run));
        t1.Name = "Secundária - ";
        t1.Start();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread atual  - " + Thread.CurrentThread.Name + i);
            Thread.Sleep(1000);

        }
        Console.WriteLine("Thread Principal terminada");
        Console.Read();*/
    }

    /*public static void run()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread Atual - " + Thread.CurrentThread.Name + i);

            Thread.Sleep(1000);
        }
    }*/

}
