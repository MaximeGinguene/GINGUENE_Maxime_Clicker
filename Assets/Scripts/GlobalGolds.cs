using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalGolds : MonoBehaviour
{
    public static int goldCount;
    public GameObject goldDisplay;
    public int internalGold;

   void Update()
    {
        internalGold = goldCount;
        goldDisplay.GetComponent<TextMeshProUGUI>().text = "Gold Nuggets: " + internalGold;

    }
}
