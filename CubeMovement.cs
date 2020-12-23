using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    //private Vector3 direction;
    //public Transform target;
    //public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //direction = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -1f * Time.deltaTime * 10);
    }
}
