using UnityEngine;

public class CopperCoins : MonoBehaviour {

    private Score score;
    private float amount = 25f;

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
