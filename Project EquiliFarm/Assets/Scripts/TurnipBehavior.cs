using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TurnipBehavior : MonoBehaviour
{
    public int turnips = 0;
    public GameObject turnipPickedUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        //Destroy(gameObject);
    }



    /*void OnTriggerEnter(Collision collision)
    {
        Debug.Log("Collision" + gameObject);
        if (collision.collider.gameObject.tag == "Character")
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{
                GameObject.Destroy(gameObject);
            //}
        }
    }*/
    //public void OnTriggerEnter(Collider other)
    // {
    //Debug.Log("Collision" + gameObject);
    //gameObject = other.gameObject;
    //turnips += 1;
    //Destroy(gameObject);
    //}
}
