using UnityEngine;

public class ExamplePersistentSingletonCall : MonoBehaviour
{
    private void Start()
    {
        ExamplePersistentSingleton.Instance.DebutInt();
    }
}
