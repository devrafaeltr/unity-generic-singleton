using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                var instances = FindObjectsOfType(typeof(T));

                if (instances.Length < 1)
                {
                    GameObject instanceNewGameObject = new GameObject($"{typeof(T)}");
                    _instance = instanceNewGameObject.AddComponent<T>();
#if UNITY_EDITOR
                    Debug.LogWarning($"There is no {typeof(T)} in this scene.");
                    Debug.Log($"New instance created: {typeof(T)}", instanceNewGameObject);
#endif                    
                }
                else
                {
                    _instance = instances[0] as T;

#if UNITY_EDITOR
                    if(instances.Length > 1)
                    {
                        Debug.LogError($"There is multiple instances of {typeof(T)} in this scene. This can lead to errors.");

                        for (int i = 0; i < instances.Length; i++)
                        {
                            GameObject instanceGameObject = (instances[i] as T).gameObject;
                            Debug.LogError($"{typeof(T)} ({i + 1}): {instanceGameObject.name}", instanceGameObject);
                        }
                    }
                    else
                    {
                        Debug.Log($"Successfully created a singleton for the {typeof(T)} class.");
                    }
#endif
                }
            }

            return _instance;
        }
    }
}