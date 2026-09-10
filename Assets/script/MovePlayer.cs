using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float _velocidadeX;

    [SerializeField] Vector2 _posicao;

    [SerializeField] Rigidbody2D _rig2d;

    void Start()
    {
        _rig2d = GetComponent<Rigidbody2D>();
        _rig2d.angularVelocity = 0;
    }
    public void SetMove(InputAction.CallbackContext value)
    {
        _posicao = value.ReadValue<Vector2>();
    }
    public void SetJump(InputAction.CallbackContext value)
    {
        _rig2d.AddForceY(100);
    }
    // Update is called once per frame
    void Update()
    {
        _rig2d.linearVelocityX = _posicao.x* _velocidadeX;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("ground");
        }

    }
}
