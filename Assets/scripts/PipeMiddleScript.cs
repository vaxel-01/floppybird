using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            LogicScript.logic.addScore(1);
        }
    }
}
