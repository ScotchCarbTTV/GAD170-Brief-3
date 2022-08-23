using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonClaw : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            MechHealth.HealthDownEvent(5);
        }
    }
}
