using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    [SerializeField] GameObject winHud;
    [SerializeField] Canvas canvas;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //winHud.SetActive(true);
            Instantiate(winHud, canvas.transform.position, Quaternion.identity, canvas.transform);
            Time.timeScale = 0;
        }
    }
}
