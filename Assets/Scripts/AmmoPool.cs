using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPool : MonoBehaviour
{
    //int for max ammo
    [SerializeField] private int maxAmmo = 500;

    [SerializeField] private int currentAmmo = 500;

    public void AddAmmo(int addAmmo)
    {
        currentAmmo += addAmmo;
        currentAmmo = Mathf.Clamp(currentAmmo, 0, maxAmmo);
    }

    public int AmmoTake(int takeAmmo)
    {
        int reloadAmmo = takeAmmo;
        currentAmmo -= takeAmmo;
        if(currentAmmo < 0)
        {
            reloadAmmo += currentAmmo;
            currentAmmo = 0;
            return reloadAmmo;
        }
        else
        {
            return reloadAmmo;
        }        
    }
}
