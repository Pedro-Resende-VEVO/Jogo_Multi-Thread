using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Jogo
{
    private int[] pontos;

    private Mapa mapa;

    public Jogo()
    {
        mapa = new Mapa();
        pontos = [0, 0];
    }

    public void subirBarra()
    {
        //        mapa.subirBarra();
    }

    public void iniciarJogo()
    {

    }

    public string exibirMapa()
    {
        return mapa.exibir();
    }

    public bool marcarPonto()
    {
        return true;
    }

    private void addPonto(int jogador)
    {
    }

}

