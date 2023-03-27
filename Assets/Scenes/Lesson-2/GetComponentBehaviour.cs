using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var renderer = gameObject.GetComponent<Renderer>();
        if (renderer != null)
            renderer.material.color = Color.red;

        // get Component
        // GetComponent<Renderer>
        // GetComponentInParent // include self
        // GetComponentInChildren
        //transform.parent.GetComponentInParent<Renderer>().material = renderer.material;

        // find GameGbject
        // GameObject.Find("Target")
        //GameObject.Find("Target").GetComponent<Renderer>().material.color = Color.blue;

        //GameObject.FindGameObjectsWithTag("Target");
        foreach(var target in GameObject.FindGameObjectsWithTag("Target"))
        {
            target.GetComponent<Renderer>().material.color = Color.blue;
        }
    }   

    // Update is called once per frame
    void Update()
    {
        transform.SetParent(null);
    }

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
