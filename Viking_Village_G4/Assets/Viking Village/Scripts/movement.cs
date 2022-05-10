using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
        {
            GetComponent<FMODUnity.StudioEventEmitter>().Play();
            
        }
        else if (Input.GetButtonUp("Horizontal") && Input.GetButtonUp("Vertical"))
        {
            GetComponent<FMODUnity.StudioEventEmitter>().Stop();
        }

    }
}