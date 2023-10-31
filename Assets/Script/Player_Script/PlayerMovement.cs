using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;

    [NonSerialized] public bool isMoving;

    private void FixedUpdate()
    {
        InputSystem.onAnyButtonPress.CallOnce(ctrl => Debug.Log($"Button {ctrl} was pressed"));
    }

    private void Moving()
    {
           
    }
}
