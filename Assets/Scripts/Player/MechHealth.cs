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

    [SerializeField] GameObject loseHUD;
    [SerializeField] Canvas canvas;

    [SerializeField] AudioSource ouchSource;
    [SerializeField] AudioClip ouchClip;
    [SerializeField] AudioClip healthClip;

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
        ouchSource.PlayOneShot(ouchClip);
        if(currentHealth <= 0)
        {
            //open up the gameover menu
            Instantiate(loseHUD, canvas.transform.position, Quaternion.identity, canvas.transform);
            //Debug.Log("Death");
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
        ouchSource.PlayOneShot(healthClip);
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        float floatHealth = currentHealth / maxHealth;
        string hpText = currentHealth.ToString();
        //invoke event to update the health component of the UI
        PlayerStatDisplay.UpdateHealthBarEvent(floatHealth, hpText);
    }

    private void OnDestroy()
    {
        HealthDownEvent -= HealthDown;
        HealthUpEvent -= HealthUp;
    }
}
