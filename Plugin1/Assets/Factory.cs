using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    


public class Factory : MonoBehaviour
{
    public GameObject tree;
    public GameObject flower;
    public GameObject rock;
    public GameObject grass;
    public Transform newPosition;
    public Camera camera;
    private bool isCarrying = false;
    private GameObject objecttobeSpawned;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCarrying == true)
        {

   
            objectSpawner(objecttobeSpawned);
           // Debug.Log(objecttobeSpawned);
            
        }

        
    }

    public void flowerSpawn()
    {


        objecttobeSpawned = flower;
        
        
        isCarrying = true;
        

    }

 

    public void rockspawn()
    {
        objecttobeSpawned = rock;
        isCarrying = true;
    }
    
    public void treeSpawn()
    {
        objecttobeSpawned = tree;
        isCarrying = true;
    }



    public void objectSpawner(GameObject gameobject)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            Ray raycast;
            raycast = camera.ScreenPointToRay(mousePos);
            RaycastHit hit;




            if (Physics.Raycast(raycast, out hit, Mathf.Infinity))
            {

                Instantiate(gameobject, hit.point, Quaternion.identity);
                isCarrying = false;
            }
        }

    }
}
