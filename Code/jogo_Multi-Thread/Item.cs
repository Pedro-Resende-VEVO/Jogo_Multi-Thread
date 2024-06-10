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

    public int[] linhaAcima()
    {
        int[] posicTemp = posicao;
        posicTemp[0]++;
        return posicTemp;
    }

    public int[] linhaAbaixo()
    {
        int[] posicTemp = posicao;
        posicTemp[0]--;
        return posicTemp;
    }

    public void subir()
    {
        posicao[0]++;
    }

    public void descer()
    {
        posicao[0]++;
    }
}