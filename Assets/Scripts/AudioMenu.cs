using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] List<GameObject> menuSelections = new List<GameObject>();
    [SerializeField] List<Slider> volSliders = new List<Slider>();

    [SerializeField] AudioMixer _mixer;

    [SerializeField] GameObject menuCursor;
    [SerializeField] int currentIndex;

    [SerializeField] AudioSource menuAudio;
    [SerializeField] AudioClip moveClip;
    [SerializeField] AudioClip scrollClip;

    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject audioMenu;

    private MenuInputActions inputActions;

    //floats for master volume, music volume, voice volume and combat volume
    private float masterVol, musicVol, voiceVol, combatVol;
    //floats for the fill amount to show in the UI sliders
    private float masterfill, musicFill, voiceFill, combatFill;
    [SerializeField] private float _multiplier = 30f;

    private void Awake()
    {
        currentIndex = 0;
        inputActions = new MenuInputActions();
        inputActions.Enable();
        for (int i = 0; i < volSliders.Count; i++)
        {
            volSliders[i].onValueChanged.AddListener(HandleSliderValueChanged);
        }
    }

    private void HandleSliderValueChanged(float value)
    {
        switch (currentIndex)
        {
            case 0:
                _mixer.SetFloat("MasterVol", MathF.Log10(value) * _multiplier);
                return;
            case 1:
                _mixer.SetFloat("MusicVol", MathF.Log10(value) * _multiplier);
                return;
            case 2:
                _mixer.SetFloat("VoiceVol", MathF.Log10(value) * _multiplier);
                return;
            case 3:
                _mixer.SetFloat("UIVol", MathF.Log10(value) * _multiplier);
                return;
            case 4:
                _mixer.SetFloat("CombatVol", MathF.Log10(value) * _multiplier);
                return;
        }
    }

    private void Update()
    {
        if (inputActions.Menu.UpSelect.WasPressedThisFrame())
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
        else if (inputActions.Menu.Right.WasPressedThisFrame() == true)
        {
            //increase the volume on the current selected item
            volSliders[currentIndex].value += 0.1f;
        }
        else if (inputActions.Menu.Left.WasPressedThisFrame() == true)
        {
            volSliders[currentIndex].value -= 0.1f;
        }
        else if (inputActions.Menu.Confirm.WasPressedThisFrame() && currentIndex == 5)
        {
            mainMenu.SetActive(true);
            audioMenu.SetActive(false);
        }
    }
}
