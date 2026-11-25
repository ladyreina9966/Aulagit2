using UnityEngine;


public class InimigoControl : MonoBehaviour
{
    // Referência ao BoxCollider2D do inimigo.
    // Permite ativar ou desativar sua área de colisão.
    [SerializeField] BoxCollider2D _box;

    // Indica se o inimigo foi atingido pela cabeça do personagem.
    // true = executa a ação de morte do inimigo.
    // false = não executa essa ação.
    [SerializeField] bool _morteCabeca;

    // Referência ao objeto que contém o efeito visual de morte.
    [SerializeField] GameObject _partMorte;


    // Executado uma única vez quando o objeto é iniciado.
    void Start()
    {

    }


    // Executado a cada frame do jogo.
    // Neste script não existe nenhuma lógica sendo executada aqui.
    void Update()
    {

    }


    // Executado quando outro Collider2D entra na área Trigger do inimigo.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que entrou no Trigger possui a Tag Player.
        if (collision.gameObject.CompareTag("Player") && _morteCabeca == true)
        {
            _box.enabled = false;
            collision.GetComponent<MovePlayer>().JumpInimigo();
            _partMorte.SetActive(true);

        }
        else if (collision.gameObject.CompareTag("AtackPlayer"))
        {
            Debug.Log("soco");
            Invoke("TimeMorteSoco", 0.15f);
        }
    }
    void TimeMorteSoco()// tempo para execução
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
