using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Football_Explosion : MonoBehaviour
{
    public GameObject football_particle;
    public GameObject football;
    // Start is called before the first frame update

    private void Reset()
    {
        football = GameObject.Find("Soccer Ball");
        football_particle = football.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == football.name)
        {
            StartCoroutine(Explosion());
        }
    }

    IEnumerator Explosion()
    {
        football_particle.SetActive(true);
        LeanTween.scale(football, new Vector3(0f, 0f, 0f), 0.5f);
        yield return new WaitForSeconds(2f);
        football.SetActive(false);
        
    }
}
