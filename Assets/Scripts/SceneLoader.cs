using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
