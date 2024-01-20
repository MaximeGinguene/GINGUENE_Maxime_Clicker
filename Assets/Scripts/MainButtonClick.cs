using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainButtonClick : MonoBehaviour {

    public GameObject textBox;
    public AudioSource pickaxeSound;
    
    public void ClickTheButton()
    {
        if (!pickaxeSound.isPlaying)
        {
            pickaxeSound.Play();
        }
        GlobalGolds.goldCount += 1;

    }

}
