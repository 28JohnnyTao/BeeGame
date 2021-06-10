using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Animation anim;
    public float speed = 10f;
    public float boostSpeed = 20f;
    public float turnSpeed = 10f;
    public float liftSpeed = 10f;
    public float bankSpeed = 10f;
    public bool foundEnemy = false;
    //Use this for initialization
    void Start(){
        //anim = gameObject.GetComponent<Animation>();
        Debug.Log("Fly script added to: " + gameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * boostSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f, Space.World);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f, Space.World);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(liftSpeed * Time.deltaTime, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(-liftSpeed * Time.deltaTime, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, bankSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -bankSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown("space"))
        {
            print("Space");
            foundEnemy = true;
        }
        if(Input.GetKeyUp("space"))
        {
            foundEnemy = false;
        }
        //transform.position += transform.forward * Time.deltaTime * 5.0f;
        // anim.Play("Idling");
        // if(Input.GetKey("space"))
        // {
        //     transform.position += transform.forward * Time.deltaTime * 5.0f;
        //     transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
        // }

        // if(Input.GetButton("Fire1"))
        // {
        //     transform.position += transform.forward * Time.deltaTime * 40.0f;
        // }
        // if(Input.GetKey(KeyCode.E))
        // {
        //     Debug.Log("Stinging animation played");
        //     //anim.Play("Bee_Stinging");
        // }


        

        

        
    }
}
