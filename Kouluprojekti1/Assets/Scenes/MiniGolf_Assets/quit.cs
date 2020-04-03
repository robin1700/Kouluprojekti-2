using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{

    public void doquit() {
        Debug.Log("has quit game");
        Application.Quit();
                // Käytä joko Application.Quit TAI SceneManager.LoadScene, ei molempia
        //SceneManager.LoadScene(" TÄNNE LADATTAVAN SCENEN NIMI ");
    }
}
