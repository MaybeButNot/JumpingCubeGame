using UnityEngine;

public class PlayerGroundDetector : MonoBehaviour
{
    [SerializeField] private PlayerMovement _pMove;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            _pMove.isJumping = false;
            _pMove.isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            _pMove.isGrounded = false;
        }
    }
}
