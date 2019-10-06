using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;
public class Project1 : MonoBehaviour
{
    //  public GameObject[] spawnables;
    public List<GameObject> spawnables = new List<GameObject>();
    private float objectNumber;
    float tempFloat = 0;
    public GameObject flower;
    public GameObject rock;
    public GameObject tree;
    public bool finishedLoading = false;

    const string DLL_NAME = "Project1";


    [DllImport(DLL_NAME)]
    private static extern int SimpleFunction();
    [DllImport(DLL_NAME)]
    private static extern void ReadInto(float objectNumber, float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern float ReadOut(int j);
    [DllImport(DLL_NAME)]
    private static extern void startWriting();
    [DllImport(DLL_NAME)]
    private static extern void endWriting();
    [DllImport(DLL_NAME)]
    private static extern int returnLines();


    private void Start()
    {
     //   loadObjects();
    }
    void Update()
    {
        //OBJECT SAVING
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Debug.Log(spawnables.Length);

            saveMap();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(spawnables.Count);
            for (int i = 0; i < spawnables.Count; i++)
            {
                Destroy(spawnables[i]);
            }



            SceneManager.LoadScene(SceneManager.GetActiveScene().name);


        }




        if (Input.GetKeyDown(KeyCode.F))
        {
            //  Debug.Log(SimpleFunction());
            finishedLoading = true;
            loadObjects();
            
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

        }

    }
    public void saveMap()
    {
        if (spawnables.Count == 0)
        {

            spawnables.AddRange(GameObject.FindGameObjectsWithTag("spawnable"));

            startWriting();

            for (int i = 0; i < spawnables.Count; i++)
            {
                if (spawnables[i].gameObject.name.Substring(0, spawnables[i].gameObject.name.Length - 7).ToLower() == "flower")
                {
                    objectNumber = 0;

                }
                else if (spawnables[i].gameObject.name.Substring(0, spawnables[i].gameObject.name.Length - 7).ToLower() == "rock")
                {
                    objectNumber = 1;

                }
                else if (spawnables[i].gameObject.name.Substring(0, spawnables[i].gameObject.name.Length - 7).ToLower() == "tree")
                {

                    objectNumber = 2;

                }
                ReadInto(objectNumber, spawnables[i].transform.position.x, spawnables[i].transform.position.y, spawnables[i].transform.position.z);

            }
            endWriting();
        }
        else if (spawnables.Count != 0)
        {

            spawnables.Clear();

            if (spawnables.Count == 0)
            {

                spawnables.AddRange(GameObject.FindGameObjectsWithTag("spawnable"));
            }
        }
    }



    public void loadObjects()
    {
        
        int objectSet = 0;

        if (returnLines() != 0)
        {
            while (finishedLoading)
            {
                Debug.Log("hello");
                for (int i = 0; i <= (returnLines() / 4); i++)
                {
                    Debug.Log(returnLines() / 4);
                    if (ReadOut(0 + objectSet) == 0)
                    {
                        Instantiate(flower, new Vector3(ReadOut(1 + objectSet), ReadOut(2 + objectSet), ReadOut(3 + objectSet)), Quaternion.identity);
                    }
                    else if (ReadOut(0 + objectSet) == 1)
                    {
                        Instantiate(rock, new Vector3(ReadOut(1 + objectSet), ReadOut(2 + objectSet), ReadOut(3 + objectSet)), Quaternion.identity);
                    }
                    else if (ReadOut(0 + objectSet) == 2)
                    {
                        Instantiate(tree, new Vector3(ReadOut(1 + objectSet), ReadOut(2 + objectSet), ReadOut(3 + objectSet)), Quaternion.identity);
                    }
                    objectSet = objectSet + 4;
                    if(objectSet == returnLines())
                    {
                        finishedLoading = false;
                        break;
                    }
                }
                finishedLoading = false;
            }
        }
    }
}