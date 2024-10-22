using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public int jumpModifier = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.linearVelocity = Vector2.up * jumpModifier;
        }
    }
}
