using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicScript.logic.onGameOver.AddListener(Resetting);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void Resetting() //Removes all pipes from game
    {
        Destroy(gameObject);
    }

}
