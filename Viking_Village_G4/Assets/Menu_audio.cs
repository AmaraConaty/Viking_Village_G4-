using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_audio : MonoBehaviour
{
    public string Select;
    public string Play;
    public string Hover;
    public string Back;


    public void SelectFunction()
    {
    FMODUnity.RuntimeManager.PlayOneShotAttached(Select, gameObject);
    }
    public void PlayFunction()
    {
    FMODUnity.RuntimeManager.PlayOneShotAttached(Play, gameObject);
    }
    public void HoverFunction()
    {
    FMODUnity.RuntimeManager.PlayOneShotAttached(Hover, gameObject);
    }
    public void BackFunction()
    {
    FMODUnity.RuntimeManager.PlayOneShotAttached(Back, gameObject);
    }
}

    