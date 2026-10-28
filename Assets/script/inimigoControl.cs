using UnityEngine;

public class inimigocontrol : MonoBehaviour
{
    [SerializeField] BoxCollider2D _box;
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
            Debug.Log("Tocou no Player");
            
        }
        
    }
}
