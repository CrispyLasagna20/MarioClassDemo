using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.RIghtArrow))
        {
            Vector2 curPos = gameObject.transform.position;
            Vector2 newPos = new Vector2(curPos.x + Time.deltaTime * speed, curPos.y);
            gameObject.transform.position = newPos;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 curPos = gameObject.transform.position;
            Vector2 newPos = new Vector2(curPos.x - Time.deltaTime * speed, curPos.y);
            gameObject.transform.position = newPos;
        }
    }
}
