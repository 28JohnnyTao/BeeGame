using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    int honey = 0;
    int nectar = 0;
    public TextMeshProUGUI honeyText;
    public TextMeshProUGUI nectarText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        transform.Rotate(Input.GetAxis("Vertical"),0.0f,-Input.GetAxis("Horizontal"));
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Hive"){
            honey += 10;
            honeyText.text = "Honey: " + honey.ToString();
        }
        if(other.gameObject.tag == "Planter"){
            nectar += 10;
            nectarText.text = "Nectar: " + nectar.ToString();
        }
    }
}
