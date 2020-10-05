using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotation : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.zero);

        Vector3 rotate = new Vector3(0, speed, 0);
        transform.Rotate(rotate);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = new Vector3(0, speed, 0);

        transform.Rotate(rotate);
    }
}
