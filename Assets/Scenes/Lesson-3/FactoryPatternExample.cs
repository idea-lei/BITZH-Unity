using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FactoryPatternExample
{
    // do not use!
    //public FactoryPatternExample()
    //{
    //    Task.Delay(10_000).Wait();
    //    Values = new int[10_000];
    //    for (int i = 0; i < Values.Length; i++)
    //    {
    //        Values[i] = i;
    //    }
    //}

    public int[] Values { get; set; }

    public static async Task<FactoryPatternExample> Create()
    {
        await Task.Delay(10_000);
        int[] values = new int[10_000];
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i;
        }
        return new FactoryPatternExample()
        {
            Values = values
        };
    }
}
