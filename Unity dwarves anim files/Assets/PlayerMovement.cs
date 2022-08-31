using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _runVelocity = 20f;
    public float _fallSpeed = 2f;
    public float _jumpForce = 1.5f;
    public int _maxJump = 2;

    private int _jumpNB = 0;

    [Header("Other impacted Gameobject in script")]
    public GameObject _graphicDwarves;
    public Rigidbody2D _rdbdDwarves;
    public Animator _animator;

    private float _x;
    private bool _y;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
         _x = Input.GetAxisRaw("Horizontal") ;
         _y = Input.GetButtonDown("Vertical");
        

     
    }
    private void FixedUpdate()
    {
        _rdbdDwarves.velocity = new Vector2(_x * _runVelocity, _rdbdDwarves.velocity.y);

        if (_x == 0 )
        {
            _animator.SetBool("isIdle", true);
        }
        else
        {
            _animator.SetBool("isIdle", false);
        }
        ;
        if (_y == true)
        {
            
            _rdbdDwarves.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _animator.SetBool("isJumping", true);
        }
        else
        {
            _animator.SetBool("isJumping", false);
        };
        if (_animator.GetBool("isJumping") == false &&  _animator.GetBool("isIdle") == false && _animator.GetBool("isRunning") == false && _rdbdDwarves.velocity.y < 0 )
        {

            _animator.SetBool("isFalling", true);
        }
        else
        {
            _animator.SetBool("isFalling", false);
        }
        if (_x < 0 || _x > 0)
        {
            _animator.SetBool("isRunning", true);
        }
        else
        {
            _animator.SetBool("isRunning", false);
        }
    }
}
   
