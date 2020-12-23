using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Cube")
        {
            Debug.Log(col.gameObject.name);
        }
    }
}
