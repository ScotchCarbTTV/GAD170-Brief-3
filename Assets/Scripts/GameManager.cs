using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    //reference to the player controller components
    [SerializeField] private MechLegs legs;
    [SerializeField] private MechTorso torso;
    [SerializeField] private GameObject protectWall;

    [SerializeField] private GameObject winHUD;
    
    string openingText1 = "Captain? CAPTAIN? Are you alive? Press (X)/(A) if you're there.";
    string openingText2 = "Good, you're alive. Lucky that mech can take a beating.";
    string openingText3 = "We've been board by demons. Category 7 breach on all decks.";
    string openingText4 = "Most of the crew is dead and the ship is going down any moment now.";
    string openingText5 = "You need to get out ASAP. Get to the mech drop bay before we drop out of the sky.";
    string openingText6 = "Good luck, Captain.";

    int dialoguePhase;

    private PlayerInputActions inputActions;

    public delegate void SceneChanger(int scene);
    public static SceneChanger SceneChangeEvent;

    //switch off the player leg and player controller
    private void Awake()
    {
        Time.timeScale = 1;
        SceneChangeEvent += NewScene;
        //winHUD.SetActive(false);
        
        inputActions = new PlayerInputActions();
        inputActions.Enable();
        dialoguePhase = 1;
        legs.enabled = false;
        torso.enabled = false;
        protectWall.SetActive(true);
    }

    private void Start()
    {
        OpeningDialogue(dialoguePhase);
    }

    private void Update()
    {
        if (inputActions.Menu.ConfirmInput.WasPressedThisFrame())
        {            
            dialoguePhase++;
            OpeningDialogue(dialoguePhase);
        }
    }

    private void OpeningDialogue(int phase)
    {
        switch (dialoguePhase)
        {
            case 1:
                DialogueDisplay.ShowDialogueEvent(openingText1, 999f, true);
                break;
            case 2:
                DialogueDisplay.ShowDialogueEvent(openingText2, 999f, true);
                break;
            case 3:
                DialogueDisplay.ShowDialogueEvent(openingText3, 999f, true);
                break;
            case 4:
                DialogueDisplay.ShowDialogueEvent(openingText4, 999f, true);
                break;
            case 5:
                DialogueDisplay.ShowDialogueEvent(openingText5, 999f, true);
                break;
            case 6:
                DialogueDisplay.ShowDialogueEvent(openingText6, 5f, true);
                legs.enabled = true;
                torso.enabled = true;
                protectWall.SetActive(false);
                break;
        }

        //DialogueDisplay.UpdatePortraitEvent(portrait, "Lt. Briggs");
    }

    private void NewScene(int scene)
    {   

        SceneManager.LoadScene(scene);        
    }

}
