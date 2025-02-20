using UnityEngine;
using System.Collections.Generic;
public class InstatiatePreFab : MonoBehaviour
{

    public GameObject prefabPerson;

    public GameObject ButtonAddPrefab;

    // public GameObject[] preFabArr; // Array
    public List<GameObject> preFabArr = new List<GameObject>();
    // public int ArrCount = 0;

    float xPos = -10f;
    float yPos = -10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // MakePreFab();
        // MakePreFab();
        // MakePreFab();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MakePreFab() {
        xPos += 60f;
        yPos += 60f;
        // ArrCount++;
        // Vector3 prefabPosition = new Vector3(xPos, yPos, 0f);
        Vector3 prefabPosition = new Vector3(Random.Range(-60.0f, 60.0f), Random.Range(-100.0f, 100.0f), Random.Range(0f, 600.0f));
        GameObject myGameObj = Instantiate(prefabPerson, prefabPosition, Quaternion.identity);
        // preFabArr[ArrCount] = myGameObj;
        preFabArr.Add(myGameObj);
        Debug.Log(preFabArr);
    }

    public void RemoveItem() {
        Destroy();
    }

    // find out how to click on item and remove it? 
    // or last item added to the array?
    // Destroy();
}
