using UnityEngine;

public class SilverCoins : MonoBehaviour {

    public float amount = 5f;

    private Score score;

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
