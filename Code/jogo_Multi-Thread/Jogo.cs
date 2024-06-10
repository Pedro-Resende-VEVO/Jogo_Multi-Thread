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

    public void subirJog()
    {
        mapa.subirItem(jogBar);
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

