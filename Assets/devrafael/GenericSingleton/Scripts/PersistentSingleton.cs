using UnityEngine;

public class PersistentSingleton<T> : BaseSingleton<T> where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            return BaseInstance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = Instance;
            DontDestroyOnLoad(this);
        }
        else
        {
#if UNITY_EDITOR
            if (SHOW_DEBUG)
            {
                Debug.Log($"This scene already have a instance to {typeof(T)}. Deleting duplicates.");
            }
#endif
            Destroy(gameObject);
        }
    }
}