using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Program
{
    public static bool cond;

    public Program(){
        cond = false;
    }

    private static Jogo jogo = new Jogo();
    static void Main(string[] args)
    {
        Thread.CurrentThread.Name = "====Placar====\n";

        Thread tInputs = new Thread(new ThreadStart(inputs));
        Thread tMapa = new Thread(new ThreadStart(mapa));
        Thread tAdversario = new Thread(new ThreadStart(adversario));
        Thread tBola = new Thread(new ThreadStart(bola));
        Thread tPontuar = new Thread(new ThreadStart(pontuar));

        Console.WriteLine("=================Sesa's Pong=================\n");
        Console.WriteLine(" | Esta barra é você, a outra é sua inimiga!");
        Console.WriteLine(" V");
        Console.WriteLine(jogo.exibirMapa());

        Console.WriteLine("**Instrunções:**");
        Console.WriteLine("1 - Seu objetivo e fazer a bola (\"0\") passar pela rede (\"#\") adversária;");
        Console.WriteLine("2 - Caso a bola passe pela rede, será marcado um ponto! Após 3 pontos teremos um vencedor;");
        Console.WriteLine("3 - Faça com que sua barra (\"]\") esteja na frente da bola quando ela vier;");
        Console.WriteLine("4 - Use \"W\" para subir e \"S\" para descer sua barra;");
        Console.WriteLine("5 - Tudo além de \"W\" e \"S\" será desconsiderado.");
        Console.WriteLine("\n(Aperte qualquer tecla para iniciar o jogo)");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine(Thread.CurrentThread.Name + jogo.placarAtual());
        tInputs.Start();
        tMapa.Start();
        tAdversario.Start();
        tBola.Start();
        tPontuar.Start();

        while (cond != true)
        {
            if (jogo.existeVencedor())
            {
                cond = true;
            }
            Console.WriteLine(Thread.CurrentThread.Name + jogo.placarAtual());
            Thread.Sleep(1000);
        }

        Console.WriteLine("O jogo terminou! o vencedor é: " + jogo.definirVencedor());
        Console.WriteLine("\nObrigado por jogar!");
    }

    static void inputs()
    {
        string s;
        while (cond != true)
        {
            s = Console.ReadLine()!;
            if (s == "W" || s == "w")
                jogo.subirItem(1);
            else if (s == "S" || s == "s")
                jogo.descerItem(1);
            Thread.Sleep(500);
        }
    }

    static void mapa()
    {
        while (cond != true)
        {
            Console.Clear();
            Console.WriteLine(jogo.exibirMapa());
            Thread.Sleep(1000);
        }
    }

    static void adversario()
    {
        Random rand = new Random();
        while (cond != true)
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
        while (cond != true)
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
        while (cond != true)
        {
            jogo.validarPonto();
            Thread.Sleep(2000);
        }
    }
}
