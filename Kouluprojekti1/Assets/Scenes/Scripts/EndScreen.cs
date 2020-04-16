using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void MainMenu()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Menu");

        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            //SceneManager.LoadScene("Menu");
            Debug.Log("QUIT");
            Application.Quit();
        }
    }
}
