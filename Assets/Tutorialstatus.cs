using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialstatus : MonoBehaviour
{
    string playerFrabs;
    public bool onOff;
    // Start is called before the first frame update
    private void Start()
    {
        playerFrabs = PlayerPrefs.GetString("tutorial_status");

        if (onOff)
        {
            PlayerPrefs.SetString("tutorial_status", "0");

        }
        else if (onOff == false)
        {
            PlayerPrefs.SetString("tutorial_status", "");
        }

    }
    // Update is called once per frame
   
}
