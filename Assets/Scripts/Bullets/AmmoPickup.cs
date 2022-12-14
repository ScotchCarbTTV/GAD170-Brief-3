using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] private int ammo;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Ping");
        if (other.gameObject.tag == "Player")
        {
            AmmoPool.GainAmmoEvent(ammo);
            PlayerStatDisplay.AmmoPoolUpEvent(ammo);
            string text = "Picked up " + ammo + " ammunition.";
            DialogueDisplay.ShowDialogueEvent(text, 5f, false);
            Destroy(gameObject);
        }
    }
}
