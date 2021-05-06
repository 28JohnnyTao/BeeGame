using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    //Use this for initialization
    void Start(){
        Debug.Log("Fly script added to: " + gameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 5.0f;
        if(Input.GetButton("Fire1"))
        transform.position += transform.forward * Time.deltaTime * 40.0f;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        
    }
}
