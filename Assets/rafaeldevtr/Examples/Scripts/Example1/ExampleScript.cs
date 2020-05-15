using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{  
    private void Start()
    {
        ExampleSingleton.Instance.SomeCoolFunction();
    }
}