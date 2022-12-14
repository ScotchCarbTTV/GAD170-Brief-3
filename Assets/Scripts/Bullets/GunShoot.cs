using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/*
 * Attaches to the gun objects on the mechtorso and responds to the shooting inputs to instantiate/reposition and add velocity to bullets
 */

public class GunShoot : MonoBehaviour
{
    //reference to the ammopool script which handles bullets

    //list of bullets in this guns magazine

    //temporary until i work out the item preloading
    [SerializeField] private Bullet bulletPref;

    [SerializeField] private AmmoPool ammoPool; 

    //ints for ammo
    [SerializeField] private int ammoCount;
    private int ammoMax;

    //enum for whether this is left or right gun
    private enum GunType { left, right }

    [SerializeField] GunType gunType;

    [SerializeField] AudioSource cannonAudio;
    [SerializeField] AudioClip shooting;
    [SerializeField] AudioClip windingDown;
    [SerializeField] AudioClip reloading;
    [SerializeField] AudioClip noAmmo;

    private PlayerInputActions inputActions;

    private bool shoot;
    private float delay;


    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Enable();
        shoot = false;
    }

    void Start()
    {
        ammoCount = 100;
        ammoMax = 100;
    }


    void Update()
    {
        //if left/right trigger is held
        if (ammoCount == 0)
        {
            DialogueDisplay.ShowDialogueEvent("RELOAD RELOAD RELOAD RELOAD RELOAD RELOAD", 1f, false);
        }

        if (gunType == GunType.left && inputActions.MechTorso.ShootLeft.WasPressedThisFrame() == true)
        {
            shoot = true;
            

        }
        else if (gunType == GunType.right && inputActions.MechTorso.ShootRight.WasPressedThisFrame() == true)
        {
            shoot = true;            
        }
        else if (gunType == GunType.right && inputActions.MechTorso.ShootRight.WasReleasedThisFrame() == true)
        {
            shoot = false;
            if (ammoCount > 0)
            {
                cannonAudio.Stop();
                cannonAudio.PlayOneShot(windingDown);
            }
            else
            {
                cannonAudio.Stop();
            }
        }
        else if (gunType == GunType.left && inputActions.MechTorso.ShootLeft.WasReleasedThisFrame() == true)
        {
            shoot = false;
            cannonAudio.loop = false;
            if (ammoCount > 0)
            {
                cannonAudio.Stop();
                cannonAudio.PlayOneShot(windingDown);
            }
            else
            {
                cannonAudio.Stop();
            }
        }

        if (ammoCount != 0 && shoot == true && delay < 0)
        {
            delay = 0.15f;
            if (gunType == GunType.left)
            {
                
                //invoke shoot
                Shoot();
                ammoCount -= 1;
                PlayerStatDisplay.ReducedAmmoLEvent(1);
            }
            else
            {
                
                //invoke shoot
                Shoot();
                ammoCount -= 1;
                PlayerStatDisplay.ReducedAmmoREvent(1);
            }
        }
        else
        {
            delay -= Time.deltaTime;
        }
        
        if(gunType == GunType.right && inputActions.MechTorso.ReloadRight.WasPressedThisFrame())
        {

            int reloadAmountR = AmmoPool.LoseAmmoEvent(ammoMax - ammoCount);
                //ammoPool.AmmoTake(ammoMax - ammoCount);
            ammoCount += reloadAmountR;
            cannonAudio.loop = false;
            cannonAudio.PlayOneShot(reloading);
            PlayerStatDisplay.GainedAmmoREvent(reloadAmountR);
            PlayerStatDisplay.AmmoPoolDownEvent(reloadAmountR);
        }
        else if(gunType == GunType.left && inputActions.MechTorso.ReloadLeft.WasPressedThisFrame())
        {
            int reloadAmountL = ammoPool.AmmoTake(ammoMax - ammoCount);
            ammoCount += reloadAmountL;
            cannonAudio.loop = false;
            cannonAudio.PlayOneShot(reloading);
            PlayerStatDisplay.GainedAmmoLEvent(reloadAmountL);
            PlayerStatDisplay.AmmoPoolDownEvent(reloadAmountL);
        }

    }

    public void Shoot()
    {
        Bullet newBullet = Instantiate(bulletPref, transform.position, transform.rotation);
        newBullet.BulletShoot(transform.forward);
        if (ammoCount > 0)
        {
            cannonAudio.clip = shooting;
            cannonAudio.loop = true;
            cannonAudio.Play();
        }
        else
        {
            cannonAudio.Stop();
        }
    }

}
