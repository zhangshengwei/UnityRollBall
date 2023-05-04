using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up);
    }



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Food Collision , target tag = " + collision.collider.tag);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Food Trigger , target tag = " + other.tag);
    }
}
