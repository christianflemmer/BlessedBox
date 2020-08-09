using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    /// <summary>
    /// Start game, ie. load first level.
    /// </summary>
    public void StartGame(

    ) {
        SceneManager.LoadScene("Level_01");
    }

}
