using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    /// <summary>
    /// Handle event of trigger enter.
    /// </summary>
    private void OnTriggerEnter(

    ) {
        gameManager.CompleteLevel();
    }
}
