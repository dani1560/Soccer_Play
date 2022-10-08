using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startForce;
    Rigidbody rb;
    int forceUp;
    float ball_rotation_counter;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);
        forceUp = 0;
        ball_rotation_counter = 10.0f;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 6.0f * ball_rotation_counter * Time.deltaTime, 0);

        if (Input.touches[0].phase == TouchPhase.Began)
        {
            //gameObject.transform.Translate(Vector3.up * 200 * Time.deltaTime, Space.Self);
            rb.AddForce(Vector3.up * 800 * Time.deltaTime ,ForceMode.VelocityChange);
            gameObject.GetComponent<AudioSource>().Play();

            Debug.Log("position -> "+ Input.GetTouch(0).position.x);

            if (Input.GetTouch(0).position.x >= 230f && Input.GetTouch(0).position.x <= 500f)
            {
                rb.AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
                forceUp = 1;
                Debug.Log("STEP 1");
            }
            else if (Input.GetTouch(0).position.x < 230f)
            {
                rb.AddForce(new Vector3(4f, 5f, 0f), ForceMode.Impulse);
                forceUp = 2;
                Debug.Log("STEP 2");

            }
            else if (Input.GetTouch(0).position.x > 500f)
            {
                rb.AddForce(new Vector3(-4f, 5f, 0f), ForceMode.Impulse);
                forceUp = 0;
                Debug.Log("STEP 3");
            }
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
