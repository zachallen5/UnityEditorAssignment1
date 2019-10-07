using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchManager : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            cameraSwitch();
        }

    }

    public void cameraSwitch()
    {
        if (camera1.activeSelf)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        else
        {
            camera2.SetActive(false);
            camera1.SetActive(true);
        }
    }
}
