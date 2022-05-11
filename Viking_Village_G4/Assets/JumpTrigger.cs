using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;


public class JumpTrigger : MonoBehaviour
{
    
    public EventReference eventName; //refernce event
    public FMOD.Studio.EventInstance Jump;
    
    
    
    
    void start()
    {
    

    }

    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Jump = FMODUnity.RuntimeManager.CreateInstance(eventName);
            Jump.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
            Jump.start();
            Jump.release();
        }
    }
}