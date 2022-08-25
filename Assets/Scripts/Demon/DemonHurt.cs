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

    [SerializeField] private DemonHealthBar hBar;

    [SerializeField] GameObject prefAmmoPickup25;
    [SerializeField] GameObject prefAmmoPickup50;
    [SerializeField] GameObject prefHealthPickup10;
    [SerializeField] GameObject prefHealthPickup50;

    [SerializeField] GameObject demonGib;

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
            int checkDrop = Random.Range(1, 100);
            if (checkDrop > 10)
            {

                int rollLoot = Random.Range(1, 20);
                if (rollLoot <= 10)
                {
                    Instantiate(prefAmmoPickup25, transform.position, Quaternion.identity);
                }
                else if (rollLoot > 10 && rollLoot <= 15)
                {
                    Instantiate(prefHealthPickup10, transform.position, Quaternion.identity);
                }
                else if (rollLoot > 15 && rollLoot <= 18)
                {
                    Instantiate(prefAmmoPickup50, transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(prefHealthPickup50, transform.position, Quaternion.identity);
                }
            }
            health = maxHealth;
            StatManager.KilledDemonEvent();
            demon.DespawnDemon();
            //spawn in gibs
            Instantiate(demonGib, transform.position, Quaternion.identity);
            //spawn in ammo or health
            

        }
        //update HP method
        healthAsPercent = health / maxHealth;
        //Debug.Log("healthAsPercent");
        healthBar.fillAmount = healthAsPercent;
        hBar.ToggleHealthOn(true);
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
