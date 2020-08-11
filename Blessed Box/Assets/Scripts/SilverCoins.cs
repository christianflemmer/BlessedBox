using UnityEngine;

public class SilverCoins : MonoBehaviour {

    private Score score;
    private float amount = 50f;

    private void Start(

    ) {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerEnter(

    ) {
        score.AddCoin(amount);
        gameObject.SetActive(false);
    }
}
