using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // Start is called before the first frame update
    private float zlimit = -10;
    float life = 0.2f;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < zlimit)
        {
            Destroy(gameObject);
        }
    }
}
