using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SaveGame : MonoBehaviour
{
    public int saveGameCash;
    public int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;



    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: $" + saveValue;
        saveGameCash = GlobalCash.cashCount;
        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {

            saveButton.GetComponent<Button>().interactable = false;
        }
    }
    public void SaveTheGame() {
        GlobalCash.cashCount -= saveValue;        
        PlayerPrefs.SetInt("SavedGolds", GlobalGolds.goldCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.cashCount);
        //PlayerPrefs.SetInt("SavedMiners", GlobalMiner.minePerSec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
        saveValue *= 2;
    }
}  
