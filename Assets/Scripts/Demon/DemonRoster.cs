using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonRoster : MonoBehaviour
{
    //list of all demons
    [SerializeField] List<GameObject> demonRoster;

    //reference to the demon prefab
    [SerializeField] Demon demonPref;

    //max number of demons
    [SerializeField] int demonMax = 20;

    //delegate and event for despawning any Demons which are killed
    public delegate void ReturnDemon(GameObject demon);
    public static ReturnDemon ReturnDemonEvent;

    private void Awake()
    {
        ReturnDemonEvent += AddDemon;

        for(int x = 0; x < demonMax; x++)
        {
            GameObject newDemon = Instantiate(demonPref.gameObject, transform.position, Quaternion.identity);
            demonRoster.Add(newDemon);
            newDemon.SetActive(false);
        }
    }


    public void AddDemon(GameObject demon)
    {
        demonRoster.Add(demon);
        demon.SetActive(false);
    }

    public GameObject SpawnDemon()
    {
        if(demonRoster.Count != 0)
        {
            GameObject newDemon = demonRoster[0];
            demonRoster.Remove(demonRoster[0]);
            return newDemon;
        }
        else
        {
            return null;
        }
        
    }

    private void OnDestroy()
    {
        ReturnDemonEvent -= AddDemon;
    }

}
