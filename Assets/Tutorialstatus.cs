using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialstatus : MonoBehaviour
{
    public string playerFrabs;
    public bool onOff;
    // Start is called before the first frame update
    private void Start()
    {
        playerFrabs = PlayerPrefs.GetString("tutorial_status");
    }
    // Update is called once per frame
    void Update()
    {
        if (onOff)
        {
            playerFrabs = "";

        }else if (onOff == false)
        {
            playerFrabs = "0";
        }
        
    }
}
