using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button realButton;
    public TMPro.TextMeshProUGUI realText;
    public TMPro.TextMeshProUGUI minerStats;
    public TMPro.TextMeshProUGUI recruitText;

    private GlobalMiner globalMiner;
    private void Start()
    {
        globalMiner = GlobalMiner.GetInstance();
    }

    public void UpdateGlobalMiner()
    {
        globalMiner.currentCash = GlobalCash.cashCount;
        minerStats.text = "Miner: " + globalMiner.numberOfMiners + " @ " + globalMiner.minePerSec + "Per Second";
        realText.text = "Recruit miner -$" + globalMiner.minerValue;
        recruitText.text = "Recruit miner -$" + globalMiner.minerValue;
        if (globalMiner.currentCash >= globalMiner.minerValue)
        {
            realButton.interactable = true;
        }
        else
        {
            realButton.interactable = false;
        }
        if (globalMiner.turnOffButton == true)
        {
            realButton.gameObject.SetActive(false);
            globalMiner.turnOffButton = false;
        }
    }
}
