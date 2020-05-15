using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleSingleton : Singleton<ExampleSingleton>
{
    public void SomeCoolFunction()
    {
        Debug.Log("Calling SomeCoolFunction!");
    }
}