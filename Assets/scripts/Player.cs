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
        if (Input.GetButtonDown("Jump") && LogicScript.logic.isPlaying)
        {
            rb.linearVelocity = Vector2.up * jumpModifier;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (LogicScript.logic.isPlaying)
        {
            LogicScript.logic.GameOver();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tak" && LogicScript.logic.isPlaying)
        {
            LogicScript.logic.GameOver();
        }
    }
}
