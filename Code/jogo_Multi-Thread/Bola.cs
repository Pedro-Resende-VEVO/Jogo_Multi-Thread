using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;
internal class Bola : Item, IHorizontavel
{
    bool direcao;

    const int COL_INIC = 5;

    const int LIN_INIC = 2;

    public Bola()
    {
        posicao = [LIN_INIC, COL_INIC];
        direcao = decidirDirecao();
    }

    public void mudarDirecao()
    {
        if (direcao)
            direcao = false; //Esquerda
        else
            direcao = true; //Direita
    }

    public bool direcaoAtual()
    {
        return direcao;
    }

    private bool decidirDirecao()
    {
        Random rand = new Random();
        return (rand.Next(2) % 2 == 0) ? true : false;
    }

    public void frente()
    {
        posicao[1]++;
    }

    public void tras()
    {
        posicao[1]--;
    }

}

