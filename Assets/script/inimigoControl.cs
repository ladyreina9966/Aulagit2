using UnityEngine;

public class InimigoControl : MonoBehaviour
{
    [SerializeField] BoxCollider2D _box;
    [SerializeField] bool morteCabeca;
    [SerializeField] GameObject _partMorte;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _box.enabled = false;
            if (morteCabeca == true)
            {
                collision.GetComponent<MovePlayer>().JumpInimigo();
                _partMorte.SetActive(true);
            }
            //Debug.Log("Tocou no Player");
        }
    }
}
