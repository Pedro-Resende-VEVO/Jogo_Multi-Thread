using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Mapa
{
    private string[,] MAPA;

    public Mapa()
    {
        MAPA = new[,] {
                {"-","-","-","-","-","-","-","-","-","-" },
                { "|"," "," "," "," "," "," "," "," ","|" },
                { "|"," "," "," "," "," "," "," "," ","|" },
                { "|"," "," "," "," "," "," "," "," ","|" },
                { "-","-","-","-","-","-","-","-","-","-"}
            };
    }

    public string exibir()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                sb.Append(MAPA[i, j]);
            }
            sb.AppendLine();
        }

        return sb.ToString();
    }

    public bool addItem(int[] posicao, string valor)
    {
        if (MAPA[posicao[0], posicao[1]] == " ")
        {
            MAPA[posicao[0], posicao[1]] = valor;
            return true;
        }

        return false;
    }

    public bool removerItem(int[] posicao, string valor)
    {
        if (MAPA[posicao[0], posicao[1]] == valor)
        {
            MAPA[posicao[0], posicao[1]] = " ";
            return true;
        }

        return false;
    }
}

