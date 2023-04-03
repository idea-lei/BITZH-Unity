using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentBehavior : MonoBehaviour
{
    //[SerializeField]
    //private GameObject child_Cube;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.childCount);
        for(int i = 0; i < transform.childCount; i++)
        {
            Debug.Log(transform.GetChild(i).name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
