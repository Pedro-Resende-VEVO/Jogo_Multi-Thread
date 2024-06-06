using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Barra : IDeslocavel
{
    private int[] posicao;

    public Barra(int colInic)
    {
        posicao = [ 2, colInic ];
    }

    public int[] valPosicao()
    {
        return posicao;
    }

    public void mover()
    {
    }

    public void deslocar()
    {
    }
}
