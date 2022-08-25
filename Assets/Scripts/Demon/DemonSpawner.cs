using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DemonSpawner : MonoBehaviour
{
    [SerializeField] DemonRoster roster;

    private Demon demon;

    private void Start()
    {
        InvokeRepeating("SpawnNewDemon", 5f, 5f);
    }

    public void SpawnNewDemon()
    {
        GameObject newDemon = roster.SpawnDemon();
        if(newDemon != null) 
        {
            newDemon.transform.position = transform.position;
            newDemon.transform.eulerAngles = transform.forward;
            newDemon.SetActive(true);
            newDemon.TryGetComponent<Demon>(out demon);
            demon.SetPatrol(); 
        }
    }
}
