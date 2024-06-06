using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_Multi_Thread;

internal class Mapa
{
    private string[,] campo;

    public Mapa()
    {
        campo = new[,] {
                {"|","-","-","-","-","-","-","-","-","-","|" },
                { "#"," "," "," "," "," "," "," "," "," ","#" },
                { "#"," "," "," "," "," "," "," "," "," ","#" },
                { "#"," "," "," "," "," "," "," "," "," ","#" },
                { "|","-","-","-","-","-","-","-","-","-","|"}
            };
    }

    public string exibir()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                sb.Append(campo[i, j]);
            }
            sb.AppendLine();
        }

        return sb.ToString();
    }

    public void addItem(int[] posicao, string valor)
    {
        campo[posicao[0], posicao[1]] = valor;
    }

    public void removerItem(int[] posicao)
    {
        campo[posicao[0], posicao[1]] = " ";
    }

    public string localizarItem(int[] posicao)
    {
        return campo[posicao[0], posicao[1]];
    }
}

