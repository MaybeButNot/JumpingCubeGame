using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public int speed;
    [SerializeField] public int jumpForce;

    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
