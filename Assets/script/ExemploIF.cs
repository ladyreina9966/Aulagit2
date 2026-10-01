using JetBrains.Annotations;
using UnityEngine;

public class ExemploIF : MonoBehaviour
{
    public int vida = 100;
    void Start()
    {
        if (vida == 0)
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
        if (vida >= 18)
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
