using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    private float moveSpeed = 5f;
    private float jumpForce = 10f;
    private bool isInvulnerable = false;

    public float MoveSpeed { get; private set; }
    public bool IsInvulnerable { get; private set; }

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        //Log ปรับความเร็ว
    }

    public void SetInvulnerability(bool isEnabled)
    {
        //Log เปิด/ปิดอมตะ
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    public void Move()
    {
        
    }

    public void Jump()
    {

    }
}
