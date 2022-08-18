using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStatDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text ammoCountL;


    private int currentAmmoL;
    private int currentAmmoR;

    public delegate void LeftAmmo(int ammoL);
    public static LeftAmmo ReducedAmmoLEvent;
    public static LeftAmmo GainedAmmoLEvent;

    private void Awake()
    {
        ReducedAmmoLEvent += ReduceAmmoL;
        GainedAmmoLEvent += GainedAmmoL;
    }

    // Start is called before the first frame update
    void Start()
    {
        GainedAmmoL(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ReduceAmmoL(int ammo)
    {
        currentAmmoL -= ammo;
        ammoCountL.text = "Left Gun Ammo:\n" + currentAmmoL;
    }

    private void GainedAmmoL(int ammo)
    {
        currentAmmoL += ammo;
        ammoCountL.text = "Left Gun Ammo:\n" + currentAmmoL;
    }
}
