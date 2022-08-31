using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject audioMenu;



    [SerializeField] List<GameObject> menuSelections = new List<GameObject>();
    [SerializeField] GameObject menuCursor;
    [SerializeField] int currentIndex;

    [SerializeField] AudioSource menuAudio;
    [SerializeField] AudioClip moveClip;
    [SerializeField] AudioClip confirmClip;

    private MenuInputActions inputActions;    


    private void Awake()
    {
        
        currentIndex = 0;
        inputActions = new MenuInputActions();
        inputActions.Enable();
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
            Time.timeScale = 1f;
            GameManager.PauseGameDelEvent();        
        }
        else if (index == 1)
        {
            pauseMenu.SetActive(false);
            audioMenu.SetActive(true);            
        }
        else if (index == 2)
        {
            GameManager.SceneChangeEvent(0);
        }
        else if(index == 3)
        {
            Application.Quit();
        }
    }

}
