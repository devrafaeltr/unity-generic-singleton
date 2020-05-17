using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSingleton : LocalSingleton<ExampleSingleton>
{
    public void SomeCoolFunction()
    {
        Debug.Log("Calling SomeCoolFunction!");
    }
}