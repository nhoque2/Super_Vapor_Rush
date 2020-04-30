using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AesteroidCollision : MonoBehaviour
{
    public int i;
    private  float time = 0.0f;
    public float speed = 0.0f;
    private Rigidbody rb;
    private Vector2 screenBounds;
    public float stopCar;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)); //get width and height of screen
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject); // if the aestroid goes off the screen delete it
        }
       
    
    }
}


