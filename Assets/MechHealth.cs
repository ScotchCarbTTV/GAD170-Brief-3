using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechHealth : MonoBehaviour
{
    //this class will handle the player's health (specifically the health of the mech)

    //int for current health
    [SerializeField] private float currentHealth;
    //int for max health
    [SerializeField] private float maxHealth;

    //delegate for events triggering health loss/gain
    public delegate void ChangeHealthValue(int health);
    public static ChangeHealthValue HealthDownEvent;
    public static ChangeHealthValue HealthUpEvent;

   

    private void Awake()
    {
        maxHealth = currentHealth;
        //subscribe methods to events
        HealthDownEvent += HealthDown;
        HealthUpEvent += HealthUp;
    }

    //method for adjusting health down
    private void HealthDown(int health)
    {
        currentHealth -= health;
        if(currentHealth < 0)
        {
            //open up the gameover menu
            Debug.Log("Death");
            Time.timeScale = 0;
        }
        float floatHealth = currentHealth / maxHealth;        
        string hpText = currentHealth.ToString();
        //invoke event to update the health component of the UI
        PlayerStatDisplay.UpdateHealthBarEvent(floatHealth, hpText);
    }

    private void HealthUp(int health)
    {
        currentHealth += health;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        float floatHealth = currentHealth / maxHealth;
        string hpText = currentHealth.ToString();
        //invoke event to update the health component of the UI
        PlayerStatDisplay.UpdateHealthBarEvent(floatHealth, hpText);
    }

}
