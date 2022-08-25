using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    //when the player interacts with this door it sends out a delegate checking if the 'keyring' script has a key matching the door and will open if true.
    //otherwise it will display a message saying 'key needed'

    [SerializeField] bool open;

    private enum DoorColour { red, blue, yellow }
    [SerializeField] DoorColour doorColour;

    [SerializeField] Animation doorOpenAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            //invoke the keyring event
            if(KeyRing.KeyCheckEvent((int)doorColour) == true && !open)
            {
                //open door
                //Debug.Log("The Door Opens");
                DialogueDisplay.ShowDialogueEvent("Key confirmed. Door opening - please stand clear.", 5f, false);
                doorOpenAnim.Play();
                open = true;
            }
            else if(KeyRing.KeyCheckEvent((int)doorColour) == true && open)
            {
                return;
            }
            else
            {
                //display 'you need the key'
                //Debug.Log("You need the " + doorColour + " Key!");
                DialogueDisplay.ShowDialogueEvent("You need the " + doorColour + " key!", 5f, false);
            }
        }
    }
}
