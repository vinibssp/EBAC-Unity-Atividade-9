using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    public float velocidade = 10f;
    public bool isPlayerEsquerda;
    public float limiteY = 4.15f;

    void Update()
    {
        float entrada = 0f;

        if (isPlayerEsquerda)
        {
            if (Keyboard.current.wKey.isPressed) entrada = 1f;
            if (Keyboard.current.sKey.isPressed) entrada = -1f;
        }
        else
        {
            if (Keyboard.current.iKey.isPressed) entrada = 1f;
            if (Keyboard.current.kKey.isPressed) entrada = -1f;
        }

        Vector3 novaPosicao = transform.position + Vector3.up * entrada * velocidade * Time.deltaTime;
        novaPosicao.y = Mathf.Clamp(novaPosicao.y, -limiteY, limiteY);
        transform.position = novaPosicao;
    }
}