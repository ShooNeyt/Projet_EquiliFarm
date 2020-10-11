using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRemoving : MonoBehaviour
{
    public float timeBeforeDisappearing = 1;
    public float currentTimeBeforeDisappearing = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeBeforeDisappearing += Time.deltaTime;
        if(currentTimeBeforeDisappearing > timeBeforeDisappearing)
        { 
            Destroy(gameObject);
        }
    }
}
