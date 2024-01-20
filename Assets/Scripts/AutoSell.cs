using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoSell : MonoBehaviour
{

    public bool sellingGold = false;
    public static int cashIncrease = 1;
    public int internalIncrease;



    void Update()
    {
        cashIncrease = GlobalShop.resellsPerSec;
        internalIncrease = cashIncrease;
        if (sellingGold == false)
        {
            sellingGold = true;
            StartCoroutine(SellTheGold());
        }

        IEnumerator SellTheGold()
        {
            if (GlobalGolds.goldCount >= internalIncrease)
            {
                GlobalCash.cashCount += internalIncrease;
                GlobalGolds.goldCount -= internalIncrease;
            }
            else if (GlobalGolds.goldCount > 0)
            {
                GlobalCash.cashCount += GlobalGolds.goldCount;
                GlobalGolds.goldCount = 0;
            }
            yield return new WaitForSeconds(1);
            sellingGold = false;
        }



    }
}