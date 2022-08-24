using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private enum KeyColour { red, blue, yellow }
    [SerializeField] KeyColour keyColour;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            KeyRing.KeyGetEvent((int)keyColour);
            gameObject.SetActive(false);
        }
    }
}
