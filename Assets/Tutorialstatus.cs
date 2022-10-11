using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialstatus : MonoBehaviour
{
    //Script by Syed Daniyal Shahid

    string playerFrabs;
    public bool onOff;
   
    private void Start()
    {
        playerFrabs = PlayerPrefs.GetString("tutorial_status");

    }
   
}
