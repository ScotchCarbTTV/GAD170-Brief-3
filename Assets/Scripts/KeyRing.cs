using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRing : MonoBehaviour
{
    //will have delegate and events which will add keys to the keyring and confirm that the key is held

    private bool hasRed, hasBlue, hasYellow;

    public delegate bool KeyCheck(int keyColour);
    public static KeyCheck KeyCheckEvent;
   

    public delegate void KeyGet(int keyColour);
    public static KeyGet KeyGetEvent;

    private void Awake()
    {
        KeyCheckEvent += HaveKey;
        KeyGetEvent += AddKey;

        hasRed = false;
        hasBlue = false;
        hasYellow = false;
    }

    public bool HaveKey(int keyColour)
    {
        if(keyColour == 0)
        {
            if(hasRed == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if(keyColour == 1)
        {
            if(hasBlue == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if(keyColour == 2)
        {
            if(hasYellow == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    public void AddKey(int keyColour)
    {
        if (keyColour == 0)
        {
            hasRed = true;
            //update UI
            DialogueDisplay.ShowDialogueEvent("Picked up the RED key!", 5f, false);
        }
        else if (keyColour == 1)
        {
            hasBlue = true;
            //updte UI
            DialogueDisplay.ShowDialogueEvent("Picked up the BLUE key!", 5f, false);
        }
        else if (keyColour == 2)
        {
            hasYellow = true;
            //update UI
            DialogueDisplay.ShowDialogueEvent("Picked up the YELLOW key!", 5f, false);
        }
    }
}
