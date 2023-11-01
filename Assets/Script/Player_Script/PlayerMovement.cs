using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _pControl;
    private Vector2 _direction;

    [NonSerialized] public bool isGrounded;
    [NonSerialized] public bool isMoving;
    [NonSerialized] public bool isJumping;

    private void FixedUpdate()
    {
        PlayerStatus();
        _pControl.rb.velocity = new Vector2(_direction.x * _pControl.speed, _pControl.rb.velocity.y);
    }

    private void OnMove(InputValue value)
    {
        _direction = value.Get<Vector2>();
    }

    private void OnJump()
    {
        if (isGrounded)
        {
            isJumping = true;
            _pControl.rb.AddForce(Vector2.up * _pControl.jumpForce, ForceMode2D.Impulse);
        }
    }

    private void PlayerStatus()
    {
        if (_direction != Vector2.zero || !isGrounded)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }
}
