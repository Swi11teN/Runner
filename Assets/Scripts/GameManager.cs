using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinText;
    public TMP_Text healthText;
    private int playerHealth = 3;
    public GameObject gameOverScreen;
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + playerHealth;
    }

    private void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = "Coins: " + coins;
        Debug.Log(coins);
    }

    public void Damage()
    {
        playerHealth--;

        if (playerHealth <= 0)
        {
            playerHealth = 0;
            GameOver();
        }

        healthText.text = "Health: " + playerHealth;
        Debug.Log(playerHealth);
    }

    public void Win()
    {
        winScreen.SetActive(true);
    }
}
