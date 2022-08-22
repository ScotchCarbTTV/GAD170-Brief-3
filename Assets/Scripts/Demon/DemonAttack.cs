using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonAttack : MonoBehaviour
{
    //reference to the hurtobject
    [SerializeField] GameObject claw;

    //float for attack timer
    [SerializeField] private float attackTimerDelay;

    private void Awake()
    {
        claw.SetActive(false);
    }

    private void Update()
    {
        if(attackTimerDelay > 0)
        {
            attackTimerDelay -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        //method to turn on a game object with a hurtbox after a short delay is called, then turn it off shortly after.
        if (!claw.activeSelf && attackTimerDelay < 0)
        {
            claw.SetActive(true);
            attackTimerDelay = 1f;
            Invoke("StopAttack", 0.3f);
        }
    }

    private void StopAttack()
    {
        claw.SetActive(false);
    }

    
}
