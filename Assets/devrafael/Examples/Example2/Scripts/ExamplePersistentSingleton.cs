using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePersistentSingleton : PersistentSingleton<ExamplePersistentSingleton>
{
    private int myInt = 0;

    //Awake must override base method from PersistentSingleton
    protected override void Awake()
    {
        base.Awake();
    }

    public void DebutInt()
    {
        Debug.Log(myInt);
        myInt++;
    }
}