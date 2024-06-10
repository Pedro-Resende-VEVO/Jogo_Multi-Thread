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

    private Barra jogBar;

    private Barra advBar;

    private Bola bola;

    public Jogo()
    {
        mapa = new Mapa();
        pontos = [0, 0];

        jogBar = new Barra(1);
        advBar = new Barra(9);
        bola = new Bola();

        mapa.addItem(jogBar.posicaoAtual(), "]");
        mapa.addItem(advBar.posicaoAtual(), "[");
        mapa.addItem(bola.posicaoAtual(), "0");
    }

    public void subirItem(int tipo)
    {
        if (tipo == 1)
            mapa.subirItem(jogBar, "]");
        else if (tipo == 2)
            mapa.subirItem(advBar, "[");
        else if (tipo == 3)
            mapa.subirItem(bola, "0");
    }

    public void descerItem(int tipo)
    {
        if (tipo == 1)
            mapa.descerItem(jogBar, "]");
        else if (tipo == 2)
            mapa.descerItem(advBar, "[");
        else if (tipo == 3)
            mapa.descerItem(bola, "0");
    }

    public void moverBola()
    {
        mapa.moverBola(bola);
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

