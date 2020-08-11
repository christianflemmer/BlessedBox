using UnityEngine;

public class CopperCoins : MonoBehaviour {

    public float amount = 2f;

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
