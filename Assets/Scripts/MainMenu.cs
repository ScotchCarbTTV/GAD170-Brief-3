using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] List<GameObject> menuSelections = new List<GameObject>();
    [SerializeField] GameObject menuCursor;
    [SerializeField] int currentIndex;

    [SerializeField] AudioSource menuAudio;
    [SerializeField] AudioClip moveClip;
    [SerializeField] AudioClip confirmClip;

    [SerializeField] GameObject audioMenu;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;

    private MenuInputActions inputActions;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        currentIndex = 0;
        inputActions = new MenuInputActions();
        inputActions.Enable();
    }

    private void Start()
    {
        audioMenu.SetActive(false);
    }

    private void Update()
    {
        if (inputActions.Menu.Confirm.WasPressedThisFrame())
        {
            Button(currentIndex);
            menuAudio.PlayOneShot(confirmClip);
        }
        else if (inputActions.Menu.UpSelect.WasPressedThisFrame())
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                menuAudio.PlayOneShot(moveClip);
                menuCursor.transform.position = new Vector3(menuCursor.transform.position.x, menuSelections[currentIndex].transform.position.y, 0);
            }

        }
        else if (inputActions.Menu.DownSelect.WasPressedThisFrame())
        {
            if (currentIndex < menuSelections.Count - 1)
            {
                currentIndex++;
                menuAudio.PlayOneShot(moveClip);
                menuCursor.transform.position = new Vector3(menuCursor.transform.position.x, menuSelections[currentIndex].transform.position.y, 0);
            }
        }
        
    }


    public void Button(int index)
    {
        if (index == 0)
        {
            SceneManager.LoadScene(2);
        }
        else if(index == 1)
        {
            //open up the options menu
            audioMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
        else if(index == 2)
        {
            //open up the credits menu
            creditsMenu.SetActive(true);
            mainMenu.SetActive(false);
        }
        else if(index == 3)
        {
            Application.Quit();
        }
    }    
}
