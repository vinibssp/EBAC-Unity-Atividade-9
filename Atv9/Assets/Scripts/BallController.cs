using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocidade = 7f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LancarBola();
    }

    public void LancarBola()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;

        float direcaoX = Random.Range(0, 2) == 0 ? -1f : 1f;

        float inclinacaoY = Random.Range(-0.3f, 0.3f);

        Vector2 direcaoInicial = new Vector2(direcaoX, inclinacaoY).normalized;

        rb.linearVelocity = direcaoInicial * velocidade;
    }
}