using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 70;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int resellsPerSec;


    
    void Update()
    {
        currentCash = GlobalCash.cashCount;
        shopStats.GetComponent<TextMeshProUGUI>().text = "Resellers: " + numberOfShops +" @ " + resellsPerSec+ "Per Second";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Recruit resellers -$" + shopValue;
        realText.GetComponent<TextMeshProUGUI>().text = "Recruit resellers -$" + shopValue;
        if (currentCash >=shopValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);

        }
        else
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;  
            

        }
    }
}
