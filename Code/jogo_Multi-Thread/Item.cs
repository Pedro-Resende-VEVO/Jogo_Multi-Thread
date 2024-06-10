using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

abstract class Item
{
    protected int[] posicao;

    public Item()
    {
        posicao = [0];
    }

    public int[] posicaoAtual()
    {
        return posicao;
    }

    public void subir()
    {
        posicao[0]--;
    }

    public void descer()
    {
        posicao[0]++;
    }
}