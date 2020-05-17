using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "";
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}