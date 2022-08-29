using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _runVelocity = 1.2f;
    public float _fallSpeed = 2f;
    public float _jumpForce = 1.5f;
    public int _maxJump = 2;

    private int _jumpNB = 0;

    [Header("Other impacted Gameobject in script")]
    public GameObject _graphicDwarves;
    public Rigidbody2D _rdbdDwarves;
    public Animator _animator;


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") ;
        float y = Input.GetAxisRaw("Vertical");
        _rdbdDwarves.velocity = new Vector2(x * _runVelocity, y * _jumpForce);

        if ((x == 0 && y == 0))
        {
            _animator.SetBool("isIdle", true);
        }
        else 
        { 
            _animator.SetBool("isIdle", false); 
        }
        ;
        if (y > 0)
        {
            _animator.SetBool("isJumping", true);
        }
        else
        {
            _animator.SetBool("isJumping", false);
        };
        if (y < 0)
        {
            _animator.SetBool("isFalling", true);
        }
        else
        {
            _animator.SetBool("isFalling", false);
        }
        if (x < 0 || x > 0)
        {
            _animator.SetBool("isRunning", true);
        }
        else 
        {
            _animator.SetBool("isRunning", false);
        }
    }
    private void FixedUpdate()
    {
        
    }
}
   
