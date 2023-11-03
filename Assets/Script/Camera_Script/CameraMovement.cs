using System;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class CameraMovement : MonoBehaviour
{
    //private Boolean _cameraStartMoving = false;

    [SerializeField] private CameraController _cController;
    private Vector3 _playerY;

    private void Start()
    {
        _playerY = transform.position;
    }

    private void LateUpdate()
    {
        /*if (_cameraStartMoving)
        {
            Debug.Log("hey");
            if (_cController.player.transform.position.y > transform.position.y + 1)
            {
                Vector3 playerY = new Vector3(0, _cController.player.transform.position.y, -1);

                transform.position = Vector3.Lerp(transform.position, playerY, _cController.followSpeed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + _cController.speed * Time.deltaTime, -1);
            }
        }*/

        if (_cController.player.transform.position.y > 4.5f)
        {
            _playerY = new Vector3(0, _cController.player.transform.position.y, -1);
        }

        transform.position = Vector3.Lerp(transform.position, _playerY, _cController.followSpeed * Time.deltaTime);
    }
}
