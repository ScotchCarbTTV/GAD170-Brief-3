using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YouWinScreen : MonoBehaviour
{
    [SerializeField] TMP_Text finalScore;
        
    private void Start()
    {
        finalScore.text = "You Win!\n You survived the demonic invasion of your airship\nand escaped!\nYou killed " +
           StatManager.ReturnDemonsKilledEvent() + " demons! \nGood Job!";
    }


    public void PlayAgain()
    {
        GameManager.SceneChangeEvent(2);
    }
}
