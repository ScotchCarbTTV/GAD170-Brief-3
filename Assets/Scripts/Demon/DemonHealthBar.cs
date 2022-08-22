using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemonHealthBar : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    private Camera eventCamera;

    private void Awake()
    {
        canvas.worldCamera = Camera.main;
    }

    private void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }

}
