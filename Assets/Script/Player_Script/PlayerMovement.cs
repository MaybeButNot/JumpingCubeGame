using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    [NonSerialized] public bool isMoving;

    private Vector2 _movement;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * Time.fixedDeltaTime);
    }

    private void Moving(InputValue value)
    {
        _movement = value.Get<Vector2>();
    }
}
