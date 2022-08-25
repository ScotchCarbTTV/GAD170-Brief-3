using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] TMP_Text finalScore;

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

    private void Start()
    {
        finalScore.text = "You Died!\n The demons claim your airship and your soul\n \nYou killed " +
        StatManager.ReturnDemonsKilledEvent() + " demons! \nTry again?";
        menuCursor.transform.position = new Vector3(menuSelections[0].transform.position.x - 300, menuSelections[0].transform.position.y, 0);
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
            if(currentIndex > 0)
            {
                currentIndex--;
                menuAudio.PlayOneShot(moveClip);
                menuCursor.transform.position = new Vector3(menuSelections[0].transform.position.x - 300, menuSelections[currentIndex].transform.position.y, 0);
            }
            
        }
        else if (inputActions.Menu.DownSelect.WasPressedThisFrame())
        {
            if(currentIndex < menuSelections.Count -1)
            {
                currentIndex++;
                menuAudio.PlayOneShot(moveClip);
                menuCursor.transform.position = new Vector3(menuSelections[0].transform.position.x - 300, menuSelections[currentIndex].transform.position.y, 0);
            }
            
        }
    }


    public void Button(int index)
    {
        if (index == 0)
        {
            GameManager.SceneChangeEvent(2);
        }
        else if(index == 1)
        {
            GameManager.SceneChangeEvent(0);
        }
        else if(index == 2)
        {
            Application.Quit();
        }
    }
}
