using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpModifier = 1;
    private Vector2 startingPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        LogicScript.logic.onGameOver.AddListener(Resetting);
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && LogicScript.logic.isPlaying)
        {
            rb.linearVelocity = Vector2.up * jumpModifier;
        }
        
    }

    public void Resetting()
    {
        transform.position = startingPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( LogicScript.logic.isPlaying)
        {
            if (collision.gameObject.tag == "Golv")
            {
                LogicScript.logic.endingType = "golv";
            }
            else
            {
                LogicScript.logic.endingType = "blomma";
            }
            
            LogicScript.logic.GameOver();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tak" && LogicScript.logic.isPlaying)
        {
            LogicScript.logic.endingType = "tak";
            LogicScript.logic.GameOver();
        }
    }
}
