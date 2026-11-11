using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovePlayer : MonoBehaviour
{

    [SerializeField] float _velocidadeX;

    [SerializeField] Vector2 _posicao;

    Rigidbody2D _rig2d;

    [SerializeField] bool _checkGround;

    [SerializeField] Animator _anim;

    [SerializeField] float _speedAnim;

    [SerializeField] float _jumpForce;

    bool _isface;


    void Start()
    {
        _rig2d = GetComponent<Rigidbody2D>();

    }

    public void SetMove(InputAction.CallbackContext value)
    {
        _posicao = value.ReadValue<Vector2>();
    }
    public void SetJump(InputAction.CallbackContext value)
    {
        if (_checkGround == true)
        {
            _checkGround = false;
            _rig2d.linearVelocityY = 0;
            _rig2d.AddForceY(10 * _jumpForce);
        }
    }

    // Update is called once per frame
    void Update()
    {

        _rig2d.linearVelocityX = _posicao.x * _velocidadeX;


        _speedAnim = MathF.Abs(_rig2d.linearVelocityX);

        _anim.SetFloat("speed", _speedAnim);
        _anim.SetFloat("pulo", _rig2d.linearVelocityY);
        _anim.SetBool("ground", _checkGround);


        if (_posicao.x < 0 && _isface == false)
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
            // Debug.Log("tocou no chão");
            _checkGround = true;
        }
    }


    public void JumpInimigo()
    {
        _checkGround = false;
        _rig2d.linearVelocityY = 0;
        _rig2d.AddForceY(10 * 20);

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
        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    public void SetAtack(InputAction.CallbackContext value)
    {
        Debug.Log("Ataque");
    }
}