using UnityEngine;

public class ExemploIF : MonoBehaviour
{
    public int vida = 100;
    public int pontos;

    public int _vida;

    void ChecarVida()
    {
        if (_vida == 0)
        {
            Debug.Log("Morto");
        }
        else if (_vida == 1)
        {
            Debug.Log("vivo");
            Debug.Log("lento");
            Debug.Log("sangrando");
        }
        else if (_vida >= 2)
        {
            Debug.Log("vivo");
            Debug.Log("velocidade normal");
           
        }
    }

    void Start()
    {
        if (pontos >= 18)
        {
            Debug.Log("Maior ou igual");
        }

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
            Debug.Log("Vida difente de 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
