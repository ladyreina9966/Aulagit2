using JetBrains.Annotations;
using UnityEngine;

public class ExemploIF : MonoBehaviour
{
    public int vida = 100;
    public int pontos;

    public int _vida;

    void Checarvida()
    {
        if( vida == 0 )
        {
            Debug.Log("MORTO");
        }
        else if( pontos == 1 )
        {
            Debug.Log("vivo");
            Debug.Log("lento");
            Debug.Log("sangrando");
        }
        else if (pontos >= 2)
        {
            Debug.Log("vivo");
            Debug.Log("normal");
        }
    }
    void Start()
    {
        if (pontos == 0)
        {
            Debug.Log("gameOver");
        }
        if (vida == 100)
        {
            Debug.Log("player está vivo");
        }
        if (vida != 0)
        {
            Debug.Log("vida diferente de 0");
        }
        if (pontos >= 18)
        {
            Debug.Log("maior ou igual");
        }
        if (vida > 100)
        {
            Debug.Log("pontuação alta");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
