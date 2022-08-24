using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonHurt : MonoBehaviour

{
    //integer for the total health of the demon and maxHealth
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;

    //reference to the UI component displaying the Demon's health.
    [SerializeField] private Image healthBar;

    [SerializeField] private float healthAsPercent;

    //reference to the game object this is parented to
    [SerializeField] private Demon demon;

    private void Awake()
    {
        maxHealth = health;
    }

    private void Start()
    {
        
    }

    private void HurtDemon(int hurt)
    {
        health -= hurt;
        //if health < 1 then die
        if(health < 1)
        {
            health = maxHealth;
            demon.DespawnDemon();
            //spawn in gibs
        }
        //update HP method
        healthAsPercent = health / maxHealth;
        //Debug.Log("healthAsPercent");
        healthBar.fillAmount = healthAsPercent;
        DemonHealthBar.ToggleHealthBarEvent(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            //apply 20 damage
            HurtDemon(20);  

            //create a blood particle effect
            //play demon ouch oneshot
        }        
    }
}
