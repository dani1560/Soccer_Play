using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{   
    //Script by Syed Daniyal Shahid

    public Vector3 startForce;
    Rigidbody rb;
    public int forceUp;
    float ball_rotation_counter;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);
        forceUp = 0;
        ball_rotation_counter = 10.0f;
    }

    void Update()
    {
        transform.Rotate(0, 6.0f * ball_rotation_counter * Time.deltaTime, 0);
       
        if (Input.touches[0].phase == TouchPhase.Began)
        {
            if (gameObject.transform.localPosition.y < 20f)
            {
                //gameObject.transform.Translate(Vector3.up * 200 * Time.deltaTime, Space.Self);
               // Debug.Log("ball position -> "+ gameObject.transform.localPosition.y);
                //rb.AddForce(Vector3.up * 450 * Time.deltaTime ,ForceMode.VelocityChange);
                rb.velocity = Vector3.up * 300 * Time.deltaTime;
                gameObject.GetComponent<AudioSource>().Play();
                Debug.Log("position -> "+ Input.GetTouch(0).position.x);
            
                if (Input.GetTouch(0).position.x >= 400f && Input.GetTouch(0).position.x <= 700f)
                {
                    forceUp++;
                    if (forceUp == 4)
                    {
                        rb.AddForce(new Vector3(2f, 5f, 0f), ForceMode.Impulse);
                        forceUp = 0;
                    }
                    else
                    {
                        rb.AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
                    }
                    Debug.Log("STEP 1");

                }
                else if (Input.GetTouch(0).position.x < 400f)
                {
                    rb.AddForce(new Vector3(3f, 5f, 0f), ForceMode.Impulse);
                    Debug.Log("STEP 2");

                }
                else if (Input.GetTouch(0).position.x > 700f)
                {
                    rb.AddForce(new Vector3(-3f, 5f, 0f), ForceMode.Impulse);
                    Debug.Log("STEP 3");
                }

            }
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
