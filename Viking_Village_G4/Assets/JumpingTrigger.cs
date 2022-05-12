using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;
using FMODUnity;

public class JumpingTrigger : MonoBehaviour
{

    public EventReference eventName;
    public FMOD.Studio.EventInstance Jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
