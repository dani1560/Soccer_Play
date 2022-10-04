using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FixedViewPort : MonoBehaviour
{
    Camera cam;
    public float xPos;
    public float yPos;
    public float width;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        height = cam.pixelHeight;
        width = cam.pixelWidth;
        xPos = cam.pixelRect.x;
        yPos = cam.pixelRect.y;
    }

    // Update is called once per frame
    void Update()
    {
        cam.pixelRect = new Rect(Screen.width - xPos, Screen.height - yPos, width, height);
    }
}
