using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 mousePosition = Input.mousePosition;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Input.mousePosition;

        if (currentMousePosition != mousePosition)
        {
            transform.LookAt(currentMousePosition);
        }
    }
}
