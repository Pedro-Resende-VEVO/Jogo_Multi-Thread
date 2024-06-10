using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Program
{
    private static Jogo jogo = new Jogo();
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ThreadStart(inputs));
        t1.Name = "Inputs - ";
        Thread t2 = new Thread(new ThreadStart(mapa));
        t2.Name = "Mapa - ";

        Console.WriteLine("=================Sesa's Pong=================\n");
        Console.WriteLine(" | Esta barra é você, a outra é sua inimiga!");
        Console.WriteLine(" V");
        Console.WriteLine(jogo.exibirMapa());

        Console.WriteLine("**Instrunções:**");
        Console.WriteLine("1 - Seu objetivo e fazer a bola (\"0\") passar pela rede (\"#\") adversária;");
        Console.WriteLine("2 - Caso a bola passe pela rede, será marcado um ponto! Após 3 pontos teremos um vencedor;");
        Console.WriteLine("3 - Com que sua barra (\"]\"), esteja na frente da bola quando ela vier;");
        Console.WriteLine("4 - Use \"W\" para subir e \"S\" para descer sua barra;");
        Console.WriteLine("5 - Tudo além de \"W\" e \"S\" será desconsiderado.");
        Console.WriteLine("\n(Aperte qualquer tecla para iniciar o jogo)");
        Console.ReadLine();

        t1.Start();
        t2.Start();
    }

    static void inputs()
    {
        while (true)
        {
            string s = Console.ReadLine()!;
            if(s == "W"){
                jogo.subirBarra();
            }
            Console.WriteLine(Thread.CurrentThread.Name + s);

            Thread.Sleep(1000);
        }
    }

    static void mapa()
    {
        while (true)
        {
            Console.WriteLine(jogo.exibirMapa());
            Thread.Sleep(1000);
        }
    }
}
