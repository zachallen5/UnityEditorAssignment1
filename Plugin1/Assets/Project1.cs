using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class Project1 : MonoBehaviour
{
    const string DLL_NAME = "Project1";
    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(SimpleFunction());
        }
    }
}