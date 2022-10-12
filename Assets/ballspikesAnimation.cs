using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballspikesAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startForce;
    GameObject spike_ball;

    private void OnEnable()
    {
        spike_ball = GameObject.Find("spikeballs_all").transform.GetChild(0).gameObject;
        spike_ball.GetComponent<Rigidbody>().AddForce(startForce, ForceMode.Impulse);
    }
}
