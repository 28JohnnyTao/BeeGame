using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Animation anim;
    //Use this for initialization
    void Start(){
        anim = gameObject.GetComponent<Animation>();
        Debug.Log("Fly script added to: " + gameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        anim.Play("Idling");
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 5.0f;
        }

        if(Input.GetButton("Fire1"))
        {
            transform.position += transform.forward * Time.deltaTime * 40.0f;
        }
        if(Input.GetKey(KeyCode.E))
        {
            Debug.Log("Stinging animation played");
            anim.Play("Bee_Stinging");
        }
        

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        
    }
}
