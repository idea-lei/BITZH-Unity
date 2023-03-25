using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    //[SerializeField]
    //private Rigidbody rb;

    [SerializeField]
    private int force;

    private int InvisibleField;

    public int distance;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(distance, 0, 0);

        var rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(force, 0,0));
    }

    // Update is for editing visual properties
    void Update()
    {
        
    }

    // FixedUpdate is for editing Physical properties
    private void FixedUpdate()
    {
        //transform.position += new Vector3(0.01f, 0, 0);
        
    }
}
