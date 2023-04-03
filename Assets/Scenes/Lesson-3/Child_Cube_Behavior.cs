using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child_Cube_Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform parent = transform.parent;
        while (parent != null)
        {
            Debug.Log(parent.name);
            parent = parent.parent;
        }

        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 20);
        transform.Rotate(transform.up, 180 * Time.deltaTime);

        //GetComponent<Rigidbody>().AddForce(transform.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"trigger with {other.name}");
    }
}
