using UnityEngine;

public class GoldCoins : MonoBehaviour {

    private Score score;
    private float amount = 100f;

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
