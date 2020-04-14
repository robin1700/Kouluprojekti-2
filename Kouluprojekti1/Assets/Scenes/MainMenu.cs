using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    
    public void PlayGame()
    {

        SceneManager.LoadSceneAsync(1);
      //  StartCoroutine(LoadAsynchronously(1));
   
    }

    IEnumerator LoadAsynchronously (int v)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);
        while(!operation.isDone)
        {
            Debug.Log(operation.progress);
            yield return null;
        }


    }
         
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
