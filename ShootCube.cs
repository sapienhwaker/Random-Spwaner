using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCube : MonoBehaviour
{
    public GameObject newObject;
    public bool stop;
    private void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint contact in collision.contacts)
        {
            Vector3 pointOfCollision = contact.point;
            //Debug.Log(pointOfCollision);
            Instantiate(newObject, pointOfCollision, gameObject.transform.rotation);
        }
    }
}
