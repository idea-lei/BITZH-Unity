using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // not using physics system
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"on trigger enter with: {other.name}");
    }

    // using physics system
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"on collision enter with: {collision.gameObject.name}");
    }
}
