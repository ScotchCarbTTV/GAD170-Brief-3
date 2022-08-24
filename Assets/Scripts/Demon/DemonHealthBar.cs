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

    public delegate void DisplayHealth(bool show);
    public static DisplayHealth ToggleHealthBarEvent;

    private void Awake()
    {
        canvas.worldCamera = Camera.main;
        healthBarBack.gameObject.SetActive(false);
        healthBarFront.gameObject.SetActive(false);

        ToggleHealthBarEvent += ToggleHealthOn;
    }

    private void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }

    public void ToggleHealthOn(bool show)
    {
        if (show == true)
        {
            healthBarBack.gameObject.SetActive(true);
            healthBarFront.gameObject.SetActive(true);
            //StartCoroutine("ToggleHealthOff");
        }
        if(show == false)
        {
            healthBarBack.gameObject.SetActive(false);
            healthBarFront.gameObject.SetActive(false);
        }
    }

}
