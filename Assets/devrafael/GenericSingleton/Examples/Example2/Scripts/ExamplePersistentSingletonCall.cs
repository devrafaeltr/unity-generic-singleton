using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePersistentSingletonCall : MonoBehaviour
{
    private void Start()
    {
        ExamplePersistentSingleton.Instance.DebutInt();
    }
}
