using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {

            if (Canvas.activeSelf == false)
            {
                Canvas.SetActive(true);
            }
            else
            {
                Canvas.SetActive(false);

            }
        }
    }
}
