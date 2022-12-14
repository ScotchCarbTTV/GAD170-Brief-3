using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatDisplay : MonoBehaviour
{
    //References to the text display for the right gun and left gun ammo
    [SerializeField] private TMP_Text ammoCountL;
    [SerializeField] private TMP_Text ammoCountR;
    [SerializeField] private TMP_Text ammoPool;

    //refrence to the text display for the currentHP
    [SerializeField] private TMP_Text currentHP;

    //reference to the image for the healthbar sprite
    [SerializeField] private Image healthBar;

    //integers for storing the actual amount of ammo to be displayed for each gun
    private int currentAmmoL;
    private int currentAmmoR;
    private int currentAmmoP;
    private int ammoPMax = 500;

    //delegate and events for increasing and decreasing the ammo
    public delegate void LeftAmmo(int ammoL);   
    public static LeftAmmo ReducedAmmoLEvent;   
    public static LeftAmmo GainedAmmoLEvent;
   

    public delegate void RightAmmo(int ammoR);
    public static RightAmmo ReducedAmmoREvent;
    public static RightAmmo GainedAmmoREvent;

    public delegate void AmmoPool(int ammoP);
    public static AmmoPool AmmoPoolDownEvent;
    public static AmmoPool AmmoPoolUpEvent;

    public delegate void UpdateHealthBar(float hp, string hpTxt);
    public static UpdateHealthBar UpdateHealthBarEvent;

    private void Awake()
    {
        ReducedAmmoLEvent += ReduceAmmoL;
        ReducedAmmoREvent += ReduceAmmoR;
        GainedAmmoLEvent += GainedAmmoL;
        GainedAmmoREvent += GainedAmmoR;
        AmmoPoolDownEvent += AmmoPoolDown;
        AmmoPoolUpEvent += AmmoPoolUp;
        UpdateHealthBarEvent += HealthBar;

    }

    void Start()
    {
        GainedAmmoL(100);
        GainedAmmoR(100);
        AmmoPoolUp(500);
        
    }

    private void ReduceAmmoL(int ammo)
    {
        currentAmmoL -= ammo;
        ammoCountL.text = "Left Gun Ammo:\n" + currentAmmoL;
    }

    private void ReduceAmmoR(int ammo)
    {
        currentAmmoR -= ammo;
        ammoCountR.text = "Right Gun Ammo:\n" + currentAmmoR;
    }

    private void GainedAmmoL(int ammo)
    {
        currentAmmoL += ammo;
        ammoCountL.text = "Left Gun Ammo:\n" + currentAmmoL;
    }

    private void GainedAmmoR(int ammo)
    {
        currentAmmoR += ammo;
        ammoCountR.text = "Right Gun Ammo:\n" + currentAmmoR;
    }

    private void AmmoPoolDown(int ammo)
    {
        currentAmmoP -= ammo;
        ammoPool.text = "Ammo Reserve: \n" + currentAmmoP;
    }

    private void AmmoPoolUp(int ammo)
    {
        currentAmmoP += ammo;
        if(currentAmmoP > ammoPMax)
        {
            currentAmmoP = 500;
        }
        ammoPool.text = "Ammo Reserve: \n" + currentAmmoP;
    }

    private void HealthBar(float hp, string hpTxt)
    {
        currentHP.text = hpTxt;
        healthBar.fillAmount = hp;
    }

    private void OnDestroy()
    {
        ReducedAmmoLEvent -= ReduceAmmoL;
        ReducedAmmoREvent -= ReduceAmmoR;
        GainedAmmoLEvent -= GainedAmmoL;
        GainedAmmoREvent -= GainedAmmoR;
        AmmoPoolDownEvent -= AmmoPoolDown;
        AmmoPoolUpEvent -= AmmoPoolUp;
        UpdateHealthBarEvent -= HealthBar;
    }
}
