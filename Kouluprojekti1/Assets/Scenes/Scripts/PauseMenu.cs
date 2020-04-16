using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;
    public UnityEvent onPause = new UnityEvent();
    public UnityEvent onUnpause = new UnityEvent();

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        //if (Input.GetKeyDown("p"))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DectivateMenu();
        }
    }

    public void ActivateMenu()
        {
            Time.timeScale = 0;
            //Debug.Log( "Time.timeScale: " + Time.timeScale );
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            AudioListener.pause = true;
            pauseMenuUI.SetActive(true);
            onPause.Invoke();
        }

    public void DectivateMenu()
    {
        Time.timeScale = 1;
        //Debug.Log( "Time.timeScale: " + Time.timeScale );
        Cursor.visible = false;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
        onUnpause.Invoke();
    }

    public void QuitGame()
    {
        Debug.Log("MainMenu");
        SceneManager.LoadScene("Menu");
    }
}
