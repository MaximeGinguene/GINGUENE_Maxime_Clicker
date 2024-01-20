using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoSell;
    public GameObject AutoGold;

    public AudioSource playSound;

    [SerializeField] private Button autoSellButton, autoGoldButton;
    [SerializeField] private TextMeshProUGUI autoSellButtonText, autoGoldButtonText;

    private void Update()
    {
        autoGoldButton.interactable = GlobalCash.cashCount >= GlobalMiner.GetInstance().minerValue;
        autoGoldButtonText.text = $"Recruit miner <color=#FFF>({GlobalMiner.GetInstance().minerValue})";

        autoSellButton.interactable = GlobalCash.cashCount >= GlobalShop.shopValue;
        autoSellButtonText.text = $"Recruit reseller <color=#FFF>({GlobalShop.shopValue})";
    }

    public void StartAutoGold()
    {
        if (!autoGoldButton.interactable) return;

        playSound.Play();
        AutoGold.SetActive(true);
        GlobalCash.cashCount -= GlobalMiner.GetInstance().minerValue;
        GlobalMiner.GetInstance().minerValue *= 2;
        GlobalMiner.GetInstance().turnOffButton = true;
        GlobalMiner.GetInstance().minePerSec += 3;
        GlobalMiner.GetInstance().numberOfMiners += 1;
    }

    public void StartAutoSell()
    {
        if (!autoSellButton.interactable) return;

        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.cashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.turnOffButton = true;
        GlobalShop.resellsPerSec += 6;
        GlobalShop.numberOfShops += 1;
    }
}
