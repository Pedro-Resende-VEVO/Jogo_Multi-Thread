using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Barra : IVerticavel
{
    private int[] posicao;

    public Barra(int colInic)
    {
        posicao = [ 2, colInic ];
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

    public void mover()
    {
    }

    public void deslocar()
    {
    }
}
