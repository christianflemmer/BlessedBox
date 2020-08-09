using UnityEngine;
using UnityEngine.SceneManagement;

public enum EEndGameType {
    COLLISSION,
    FALL_OFF_EDGE,
}

public class GameManager : MonoBehaviour {

    public float restartDelay = 1f;
    public GameObject completeLevelUi;

    private bool levelHasEnded = false;

    /// <summary>
    /// Complete current level.
    /// </summary>
    public void CompleteLevel(

    ) {
        completeLevelUi.SetActive(true);
    }

    /// <summary>
    /// End level based on given enum `EEndGameType`.
    /// </summary>
    public void EndLevel(
        EEndGameType endGameType
    ) {
        if (levelHasEnded == false) {
            levelHasEnded = true;

            switch (endGameType) {
                case EEndGameType.COLLISSION:
                    Invoke("RestartLevel", restartDelay);
                    break;

                case EEndGameType.FALL_OFF_EDGE:
                    RestartLevel();
                    break;
            }

        }
    }

    /// <summary>
    /// Restart current level.
    /// </summary>
    private void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
