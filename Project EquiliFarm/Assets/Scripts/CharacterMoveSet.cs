using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveSet : MonoBehaviour
{

    [Range(0, 4000)]
    public int speed = 1;
    public Transform View;
    public Rigidbody rigidbodyPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Controle des deplacements du player
        Vector3 moveDir = Vector3.zero;
        Vector3 rotateDir = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDir.z = speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir.z = -speed;
        }
        rigidbodyPlayer.velocity = moveDir;
    }
}
