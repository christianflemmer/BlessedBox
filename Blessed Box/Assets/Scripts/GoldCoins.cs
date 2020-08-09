using UnityEngine;

public class GoldCoins : MonoBehaviour
{
    public Score score;
    public float amount = 10f;

    private void OnTriggerEnter(

    ) {
        score.AddCoin(amount);
        gameObject.SetActive(false);
    }
}
