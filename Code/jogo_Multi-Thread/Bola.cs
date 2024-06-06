using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;
internal class Bola : IDirecionavel, IDeslocavel
{
    private int[] posicao;

    bool direcaoBola;

    const int COL_INIC = 2;

    const int LIN_INIC = 3;

    public Bola()
    {
        posicao = new int[2] { COL_INIC, LIN_INIC };
        direcaoBola = decidirDirecao();
    }

    public void mudarDirecao()
    {
        if (direcaoBola)
            direcaoBola = false;
        else
            direcaoBola = true;
    }

    public bool decidirDirecao()
    {
        Random rand = new Random();
        return (rand.Next(2) % 2 == 0) ? true : false;
    }

    public int[] valPosicao()
    {
        return posicao;
    }

    public void mover()
    {
        //Thread 

        while (direcaoBola)
        {
            posicao[1]++; //Muda a linha
        }
    }

    public void deslocar()
    {
        posicao[0] = valorLinha(); //Muda a coluna
    }

    private int valorLinha()
    {
        if (posicao[0] == 1)
        {
            //Ir para 2 ou 3
        }
        else if (posicao[0] == 2)
        {
            //Ir para 1 ou 3
        }
        else if (posicao[0] == 3)
        {
            //Ir para 2 ou 1
        }

        return 0;
    }
}
