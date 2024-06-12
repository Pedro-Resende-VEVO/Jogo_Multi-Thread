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
        Thread.CurrentThread.Name = "====Placar====\n";

        bool cond = false;

        Thread t1 = new Thread(new ThreadStart(inputs));
        t1.Name = "Inputs - ";
        Thread t2 = new Thread(new ThreadStart(mapa));
        t2.Name = "Mapa - ";
        Thread t3 = new Thread(new ThreadStart(adversario));
        t3.Name = "Adversário - ";
        Thread t4 = new Thread(new ThreadStart(bola));
        t4.Name = "Bola - ";
        Thread t5 = new Thread(new ThreadStart(pontuar));
        t5.Name = "Pontuar - ";

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
        t3.Start();
        t4.Start();
        t5.Start();

        while (cond == false)
        {
            if (jogo.existeVencedor())
            {
                t1.Join();
                t2.Join();
                t3.Join();
                t4.Join();
                t5.Join();
                cond = true;
            }
            Console.WriteLine(Thread.CurrentThread.Name + jogo.placarAtual());
            Thread.Sleep(1000);
        }

        Console.WriteLine(Thread.CurrentThread.Name + jogo.placarAtual());
        Console.WriteLine("O jogo terminou! o vencedor é: " + jogo.definirVencedor());
        Console.WriteLine("\nObrigado por jogar!");
        Console.ReadLine();
    }

    static void inputs()
    {
        string s;
        while (true)
        {
            s = Console.ReadLine()!;
            if (s == "W" || s == "w")
                jogo.subirItem(1);
            else if (s == "S" || s == "s")
                jogo.descerItem(1);
            s = "";
            Thread.Sleep(500);
        }
    }

    static void mapa()
    {
        while (true)
        {
            Console.WriteLine(jogo.exibirMapa());
            Thread.Sleep(1000);
            //Console.Clear();
        }
    }

    static void adversario()
    {
        Random rand = new Random();
        while (true)
        {
            int valorAleatorio = rand.Next(0, 3);
            if (valorAleatorio == 2)
                jogo.subirItem(2);
            else if (valorAleatorio == 0)
                jogo.descerItem(2);
            //Se der 1 ele não faz nada
            Thread.Sleep(1000);
        }
    }

    static void bola()
    {
        Random rand = new Random();
        while (true)
        {
            int valorAleatorio = rand.Next(0, 3);
            if (valorAleatorio == 2)
                jogo.subirItem(3);
            else if (valorAleatorio == 0)
                jogo.descerItem(3);
            //Se der 1 ele não faz nada

            jogo.moverBola();
            Thread.Sleep(1000);
        }
    }

    static void pontuar()
    {
        while (true)
        {
            jogo.validarPonto();
            Thread.Sleep(1000);
        }
    }
}
