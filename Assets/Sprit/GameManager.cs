using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int Coins = 0;
    public TextMeshProUGUI CoinText;

    private void Awake()
    {
        if (GameManager.gameManager != null && GameManager.gameManager != this)
        Destroy(gameManager);
        else
        {
            GameManager.gameManager = this;
            DontDestroyOnLoad(gameManager);
        }
    }

     public void CoinCollected()
    {
        Coins ++;
        CoinText.text = "Coins: " + Coins;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
