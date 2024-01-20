using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SellGold : MonoBehaviour
{

    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int generateTone;

    public void ClickTheButton()

    {
        generateTone = Random.Range(1, 3);
        if (GlobalGolds.goldCount == 0)
        {
            statusBox.GetComponent<TextMeshProUGUI>().text = "Not enough Gold nugget to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if (generateTone == 1 && !cashOne.isPlaying)
            {
                cashOne.Play();
            }
            if (generateTone == 2 && !cashTwo.isPlaying)
            {
                cashTwo.Play();
            }
            GlobalGolds.goldCount -= 1;
            GlobalCash.cashCount += 1;
        }
    }
}

