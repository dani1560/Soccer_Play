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
    GameObject ballCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);
        ballCollider = GameObject.Find("ball_collider");
        forceUp = 0;
        ball_rotation_counter = 10.0f;

    }

    void Update()
    {
        transform.Rotate(0, 6.0f * ball_rotation_counter * Time.deltaTime, 0);
        ballCollider.transform.position = new Vector3(gameObject.transform.position.x, ballCollider.transform.position.y, ballCollider.transform.position.z);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if (Input.touches[0].phase == TouchPhase.Began)
        {
            if (Physics.Raycast(ray, out hit))
            {
                print("---> " + hit.collider.name);


                if (gameObject.transform.localPosition.y < 22f)
                {
                    //gameObject.transform.Translate(Vector3.up * 200 * Time.deltaTime, Space.Self);
                    // Debug.Log("ball position -> "+ gameObject.transform.localPosition.y);
                    //rb.AddForce(Vector3.up * 450 * Time.deltaTime ,ForceMode.VelocityChange);
                    rb.velocity = Vector3.up * 300 * Time.deltaTime;
                    gameObject.GetComponent<AudioSource>().Play();
                    Debug.Log("position -> " + Input.GetTouch(0).position.x);
                    Debug.Log("position ball -> " + ballCollider.transform.position.x);

                    if (hit.collider.name == "ball_collider")
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
                    else if (hit.collider.name == "ball_collider (2)")
                    {
                        rb.AddForce(new Vector3(3f, 5f, 0f), ForceMode.Impulse);
                        Debug.Log("STEP 2");

                    }
                    else if (hit.collider.name == "ball_collider (1)")
                    {
                        rb.AddForce(new Vector3(-3f, 5f, 0f), ForceMode.Impulse);
                        Debug.Log("STEP 3");
                    }

                }

            }
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
