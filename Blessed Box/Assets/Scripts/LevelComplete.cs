using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    /// <summary>
    /// Load next level based on current active scene.
    /// </summary>
    public void LoadNextLevel(

    ) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
