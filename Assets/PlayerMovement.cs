using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _runVelocity = 1.2f;
    public float _fallSpeed = 2f;
    public float _jumpForce = 1.5f;
    public int _maxJump = 3;

    private Vector2 _xMove;
    private bool _jump = false;
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
        _xMove.x = Input.GetAxis("Horizontal")*_runVelocity;
    }
}
