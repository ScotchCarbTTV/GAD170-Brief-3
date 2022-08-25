using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//this script will display information to the player such as character dialogue, button prompts and other feedback

public class DialogueDisplay : MonoBehaviour
{
    //reference to the dialogue text object
    [SerializeField] private TMP_Text dialogueText;

    //reference to the character portrait 
    [SerializeField] private Image portrait;
    //reference to the text for the dialogue screen name
    [SerializeField] private TMP_Text dialogueName;
    //reference to the dialogue panel
    [SerializeField] private GameObject dialoguePanel;


    public delegate void Dialogue(string text, float displayTime, bool showPortrait);
    public static Dialogue ShowDialogueEvent;

    public delegate void UpdatePortrait(Sprite portrait, string name);
    public static UpdatePortrait UpdatePortraitEvent;

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Portrait").TryGetComponent<Image>(out portrait);
        dialoguePanel.SetActive(false);
        ShowDialogueEvent += ShowDialogue;
        UpdatePortraitEvent += _UpdatePortrait;
    }

    private void Start()
    {
         
    }

    private void ShowDialogue(string text, float displayTime, bool _portrait)
    {

        if(_portrait == true)
        {
            portrait.gameObject.SetActive(true);
        }
        else
        {
            portrait.gameObject.SetActive(false);
        }
         
        
        
        dialogueText.text = text;
        dialoguePanel.SetActive(true);
        if (displayTime < 900f)
        {
            Invoke("ClosePanel", displayTime);
        }        
    }

    private void ClosePanel()
    {
        dialoguePanel.SetActive(false);
    }

    private void _UpdatePortrait(Sprite port, string dName)
    {
        dialogueName.text = dName;
        portrait.sprite = port;
    }

    private void OnDestroy()
    {
        ShowDialogueEvent -= ShowDialogue;
        UpdatePortraitEvent -= _UpdatePortrait;
    }

}
