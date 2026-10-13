using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] float _velocidadeX;   

    [SerializeField] Vector2 _posicao;

    Rigidbody2D _rig2d;

    [SerializeField] bool _checkGround;

    bool _isface;


    void Start()
    {
        _rig2d= GetComponent<Rigidbody2D>();
        
    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _posicao = value.ReadValue<Vector2>();
    }
    public void SetJump(InputAction.CallbackContext value)
    {
        if( _checkGround==true)
        {
            _rig2d.AddForceY(100);
        }           
    }

    // Update is called once per frame
    void Update()
    {
        _rig2d.linearVelocityX = _posicao.x* _velocidadeX;
        if(_posicao.x < 0 && _isface == false)
        {
            Flip();
        }
        else if (_posicao.x > 0 && _isface == true)
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("tocou np chão");
            _checkGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("saio do chão");
            _checkGround = false;
        }
    }
    
    private void Flip()
    {
        _isface = !_isface;
        Vector2 theScale =transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


}
