using System;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Boolean _cameraStartMoving = false;

    [SerializeField] private CameraController _cController;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _cameraStartMoving = true;
        }
    }

    private void LateUpdate()
    {
        if (_cameraStartMoving)
        {
            if (_cController.player.transform.position.y > transform.position.y + 1)
            {
                Vector3 playerY = new Vector3(0, _cController.player.transform.position.y, -1);

                transform.position = Vector3.Lerp(transform.position, playerY, _cController.followSpeed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + _cController.speed * Time.deltaTime, -1);
            }
        }
    }
}
