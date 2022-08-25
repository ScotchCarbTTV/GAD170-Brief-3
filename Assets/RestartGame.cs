using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Invoke("Restart", 1f);
    }

    private void Restart()
    {
        SceneManager.LoadScene(1);
    }

}
