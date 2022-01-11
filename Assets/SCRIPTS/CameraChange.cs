using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;

    private bool boolChange;

    private void Start()
    {
        boolChange = false;
        camera2.enabled = true;
        camera1.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("r") && boolChange == false)
        {
            camera1.enabled = true;
            camera2.enabled = false;

            boolChange = true;
        }

        else if (Input.GetKeyDown("r") && boolChange)
        {
            camera2.enabled = true;
            camera1.enabled = false;

            boolChange = false;
        }
    }
}
