using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CoinCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinCounterText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounterText.text = "Coin: " + Coin.coinCounter;
    }
}
