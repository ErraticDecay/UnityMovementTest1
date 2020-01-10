using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidboundaries : MonoBehaviour
{
    private Vector3 screenBounds1;
    public float rbmaxX;
    public float rbmaxy;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds1 = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        rbmaxX = screenBounds1.x;
        rbmaxy = screenBounds1.y;
        Debug.Log("Boundary X: " + rbmaxX + " Boundary Y: " + rbmaxy);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
