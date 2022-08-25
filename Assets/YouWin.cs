using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeField] GameObject winHud;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            winHud.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void PlayAgain()
    {
        GameManager.SceneChangeEvent(0);
    }
}
