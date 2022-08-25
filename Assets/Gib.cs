using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gib : MonoBehaviour
{
    //spawns in, refuses to elaborate, leaves

    //reference to he parent object

    private float timer;

    private void Awake()
    {
        timer = 2.5f;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
