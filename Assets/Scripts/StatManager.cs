using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    //just keeps track of the total number of demons killed

    [SerializeField] private int demonsKilled = 0;

    public delegate void KilledDemon();
    public static KilledDemon KilledDemonEvent;

    public delegate int ReturnDemonsKilled();
    public static ReturnDemonsKilled ReturnDemonsKilledEvent;

    private void Awake()
    {
        demonsKilled = 0;
        KilledDemonEvent += _KilledDemon;
        ReturnDemonsKilledEvent += ReturnDemons;
    }

    private void _KilledDemon()
    {
        demonsKilled++;
    }

    public int ReturnDemons()
    {
        return demonsKilled;
    }

    private void OnDestroy()
    {
        KilledDemonEvent -= _KilledDemon;
        ReturnDemonsKilledEvent -= ReturnDemons;
    }

}
