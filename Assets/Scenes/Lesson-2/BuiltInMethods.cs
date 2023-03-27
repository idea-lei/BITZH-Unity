using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class BuiltInMethods : MonoBehaviour
{
    private async Task Awake()
    {
        //Invoke(nameof(Print), 5);
        //InvokeRepeating(nameof(Print), 5, 2);
        //StartCoroutine(nameof(LongTimeJobCoroutine));
        await LongTimeJob();
    }
    public void Print()
    {
        Debug.Log("Hello World!");
    }

    private void Update()
    {
        // if initialized?
        Debug.Log("Update");
    }

    // Process > Thread > Coroutine
    private IEnumerator SomeCoroutine()
    {
        int i = 0;
        Debug.Log(i++);
        yield return null;
        Debug.Log(i++);
        yield return null;
        Debug.Log(i++);
        yield return null;
        Debug.Log(i++);
        yield return null;
    }

    private IEnumerator LongTimeJobCoroutine()
    {
        var task = LongTimeJob();
        while (!task.IsCompleted)
        {
            Debug.Log("task running");
            yield return null;
        }
        Debug.Log("task finished");
        StopAllCoroutines();
    }

    private async Task LongTimeJob()
    {
        await Task.Delay(2000);
        Debug.Log("task finished");
    }
}
