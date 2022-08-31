using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{ 
    [SerializeField] GameObject mainMenu;

    private MenuInputActions inputActions;

    private void Awake()
    {
        
        inputActions = new MenuInputActions();
        inputActions.Enable();
    }

    private void Update()
    {
        if (inputActions.Menu.Confirm.WasPressedThisFrame())
        {
            mainMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
