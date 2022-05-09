using UnityEngine;

public class ExampleSingleton : LocalSingleton<ExampleSingleton>
{
    public void SomeCoolFunction()
    {
        Debug.Log("Calling SomeCoolFunction!");
    }
}