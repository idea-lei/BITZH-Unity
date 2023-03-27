using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private GameObject objectToDestory;
    [SerializeField]
    private GameObject playground;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate
        // Destory
        // enabled -> Component
        // setActive -> GameObject

        var obj1 = Instantiate(playground);
        obj1.transform.position = new Vector3(20,0,0);
        var obj2 = Instantiate(playground);
        obj2.transform.position = new Vector3(20, 0, 20);
        var obj3 = Instantiate(playground);
        obj3.transform.position = new Vector3(0, 0, 20);
        var obj4 = Instantiate(playground);
        obj4.transform.position = new Vector3(0, 0, 0);

        objectToDestory = obj4;
        Invoke("DestoryObject", 5);

        obj3.SetActive(false);

        obj2.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestoryObject()
    {
        if (objectToDestory != null)
        {
            Destroy(objectToDestory);
        }
    }
}
