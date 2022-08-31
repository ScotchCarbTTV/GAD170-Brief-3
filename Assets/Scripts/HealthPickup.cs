using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] private int health;


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Ping");
        if (other.gameObject.tag == "Player")
        {
            MechHealth.HealthUpEvent(health);
            PlayerStatDisplay.AmmoPoolUpEvent(health);
            string text = "Picked up " + health + " HP.";
            DialogueDisplay.ShowDialogueEvent(text, 5f, false);
            Destroy(gameObject);
        }
    }
}
