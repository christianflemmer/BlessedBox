﻿using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;

    public float animationTime = 0.1f;

    private float desiredCoins;
    private float initialCoins;
    private float currentCoins;

    private void Start(

    ) {
        score.text = "$0";
    }

    private void Update(

    ) {
        if (currentCoins != desiredCoins) {

            // ... incrementing coins
            if (initialCoins < desiredCoins) {
                currentCoins += (animationTime * Time.deltaTime) * (desiredCoins - initialCoins);
                if (currentCoins >= desiredCoins) {
                    currentCoins = desiredCoins;
                }
            } else {
                // ... decrementing coins
                currentCoins -= (animationTime * Time.deltaTime) * (initialCoins - desiredCoins);
                if (currentCoins <= desiredCoins) {
                    currentCoins = desiredCoins;
                }
            }

            // Update current coins in this frame
            score.text = $"${currentCoins.ToString("0")}";
        }
    }

    public void AddCoin(
        float amount
    ) {
        initialCoins = currentCoins;
        desiredCoins += amount;
    }

}
