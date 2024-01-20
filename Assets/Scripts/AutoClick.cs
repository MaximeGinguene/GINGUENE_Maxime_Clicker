using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClick : MonoBehaviour
{

    public bool creatingGold = false;
    public static int goldIncrease = 1;
    public int internalIncrease;

    
    
    void Update(){
        goldIncrease = GlobalMiner.GetInstance().minePerSec;
        internalIncrease = goldIncrease;
        if (creatingGold == false)
        {
            creatingGold=true;
            StartCoroutine(CreateTheGold());
        }

        IEnumerator CreateTheGold()
        {
            GlobalGolds.goldCount += internalIncrease;
            yield return new WaitForSeconds(1);
            creatingGold = false;
        }

        
    }
}
