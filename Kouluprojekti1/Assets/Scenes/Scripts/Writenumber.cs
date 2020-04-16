using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Writenumber : MonoBehaviour
{

    public string Ruutu;
    public GameObject textdisplay;


    void Start()
    {
        Ruutu = GetComponent<CodeLock>().attemptedCode;
    }

    
    void Update()
    {
        textdisplay.GetComponent<Text>().text = Ruutu;
    }
}
