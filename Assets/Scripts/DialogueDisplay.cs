using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//this script will display information to the player such as character dialogue, button prompts and other feedback

public class DialogueDisplay : MonoBehaviour
{
    //reference to the dialogue text object
    [SerializeField] private TMP_Text dialogueText;

    //reference to the dialogue panel
    [SerializeField] private GameObject dialoguePanel;


    public delegate void Dialogue(string text, float displayTime);
    public static Dialogue ShowDialogueEvent;

    private void Awake()
    {
        dialoguePanel.SetActive(false);
        ShowDialogueEvent += ShowDialogue;
    }

    private void ShowDialogue(string text, float displayTime)
    {
        dialogueText.text = text;
        dialoguePanel.SetActive(true);
        Invoke("ClosePanel", displayTime);
    }

    private void ClosePanel()
    {
        dialoguePanel.SetActive(false);
    }

}
