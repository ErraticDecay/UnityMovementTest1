using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector2 movement;
    private Vector3 position1;
    public float xPos;
    public float yPos;
    private Vector3 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        position1 = rb.position;

        xPos = rb.position.x + movement.x * speed * Time.fixedDeltaTime;
        yPos = rb.position.y + movement.y * speed * Time.fixedDeltaTime;

        Debug.Log("Position is " + position1 + " xPos " + xPos + " yPos " + yPos);
    }
    private void FixedUpdate()
    {
        Vector3 viewPos = transform.position;
        if (xPos > -50)
        {
            movement.x = 0;
        }
       else if (yPos < -350 )
        {
            viewPos.y = Mathf.Clamp(viewPos.y, -343, -1);
            viewPos.x = Mathf.Clamp(viewPos.x, -60, -1);
            transform.position = viewPos;
        }
        else
        {
            movePlayer(movement);
        }
        
    }
    void movePlayer(Vector2 direction)
    {
        rb.MovePosition((Vector2) transform.position + (direction * speed * Time.deltaTime));
    }
}
