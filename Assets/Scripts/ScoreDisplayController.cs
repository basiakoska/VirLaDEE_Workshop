using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplayController : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject winMessage; 
    public CoinCollector coinCollector;
    private int totalCoinsCount; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        var allCoins = GameObject.FindGameObjectsWithTag("coin");
        totalCoinsCount = allCoins.Length;
        winMessage.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = $"Coins: {coinCollector.collectedCoinsCount}/{totalCoinsCount}"; //$ for interpolation (variable instead of string)
        if (coinCollector.collectedCoinsCount >= totalCoinsCount)
        {
            winMessage.SetActive(true);
        }
    }
}
