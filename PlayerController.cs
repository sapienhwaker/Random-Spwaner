using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        float horizontalMovement = UnityEngine.Random.Range(0f, 10f);
        float verticalMovement = UnityEngine.Random.Range(0f, 10f);

        Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);

        rb.AddForce(movement*speed);
    }
   // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        
        //rb.AddForce(movement*speed);
    }

}
