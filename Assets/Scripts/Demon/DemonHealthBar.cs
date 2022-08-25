using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonHealthBar : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    private Camera eventCamera;

    [SerializeField] Image healthBarFront;
    [SerializeField] Image healthBarBack;

    private float healthTimer;

    private void Awake()
    {
        healthTimer = -1f;
        canvas.worldCamera = Camera.main;
        healthBarBack.gameObject.SetActive(false);
        healthBarFront.gameObject.SetActive(false);        
    }

    private void Update()
    {
        transform.forward = Camera.main.transform.forward;
        if(healthTimer > 0)
        {
            healthTimer -= Time.deltaTime;
        }
        else if(healthTimer < 0)
        {
            ToggleHealthOn(false);
        }
    }

    public void ToggleHealthOn(bool show)
    {
        if (show == true && healthTimer < 0)
        {
            healthTimer = 3f;
            healthBarBack.gameObject.SetActive(true);
            healthBarFront.gameObject.SetActive(true);
            //StartCoroutine("ToggleHealthOff");
        }
        else if(show == false)
        {
            healthTimer = -1f;
            healthBarBack.gameObject.SetActive(false);
            healthBarFront.gameObject.SetActive(false);
        }
    }

}
