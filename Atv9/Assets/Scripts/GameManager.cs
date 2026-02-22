using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int pontosEsquerda;
    public int pontosDireita;
    public TextMeshProUGUI textoPlacar;
    public BallController scriptBola;

    public void MarcouGol(bool golNaEsquerda)
    {
        if (golNaEsquerda)
        {
            pontosDireita++;
        }
        else
        {
            pontosEsquerda++;
        }

        AtualizarInterface();
        scriptBola.LancarBola(); // Reinicia o movimento da bola
    }

    void AtualizarInterface()
    {
        textoPlacar.text = pontosEsquerda + " : " + pontosDireita;
    }
}