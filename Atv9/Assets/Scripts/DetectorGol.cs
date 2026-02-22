using UnityEngine;

public class DetectorGol : MonoBehaviour
{
    public bool ehGolDaEsquerda;
    private GameManager gerenciador;

    void Start()
    {
        gerenciador = Object.FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bola"))
        {
            gerenciador.MarcouGol(ehGolDaEsquerda);
        }
    }
}