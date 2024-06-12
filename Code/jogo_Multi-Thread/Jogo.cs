using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Jogo
{
    private int PONTOS_PARA_VENCER = 3;

    private int pontoJog;

    private int pontoIA;

    private Mapa mapa;

    private Barra jogBar;

    private Barra advBar;

    private Bola bola;

    public Jogo()
    {
        mapa = new Mapa();
        pontoJog = 0;
        pontoIA = 0;

        jogBar = new Barra(1);
        advBar = new Barra(9);
        bola = new Bola();

        mapa.addItem(jogBar.posicaoAtual(), "]");
        mapa.addItem(advBar.posicaoAtual(), "[");
        mapa.addItem(bola.posicaoAtual(), "0");
    }

    public bool existeVencedor()
    {
        return (pontoJog == PONTOS_PARA_VENCER || pontoIA == PONTOS_PARA_VENCER) ? true : false;
    }

    public string definirVencedor()
    {
        if (pontoJog == PONTOS_PARA_VENCER)
            return "Você";
        return "a Máquina";
    }

    public string placarAtual()
    {
        return "Você: " + pontoJog + " -  IA: " + pontoIA;
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

    public void validarPonto()
    {
        int resp = mapa.validarGol(bola);
        if (resp == 1)
        {
            pontoJog++;
        }
        else if (resp == 2)
            pontoIA++;
    }
}

