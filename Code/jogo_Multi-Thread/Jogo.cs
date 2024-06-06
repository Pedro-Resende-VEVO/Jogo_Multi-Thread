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

    private Barra barra1;

    private Barra barra2;

    private Bola bola;


    public Jogo()
    {
        mapa = new Mapa();
        pontos = new int[2] { 0, 0 };
        barra1 = new Barra(2, 1);
        barra2 = new Barra(8, 1);
        bola = new Bola();

        mapa.addItem(barra1.valPosicao(), "]");
        mapa.addItem(barra2.valPosicao(), "[");
        mapa.addItem(bola.valPosicao(), "0");
    }

    public void iniciarJogo()
    {

    }

    public string exibirMapa(){
        return mapa.ToString();
    }

    public bool marcarPonto()
    {
        return true;
    }

    private void addPonto(int jogador)
    {
    }

}

