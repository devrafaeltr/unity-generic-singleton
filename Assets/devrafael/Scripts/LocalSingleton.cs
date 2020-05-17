using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalSingleton<T> : BaseSingleton<T> where T : MonoBehaviour
{
    public static T Instance
    {
        get
        {
            return BaseInstance;
        }
    }
}
