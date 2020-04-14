using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CodeLock : MonoBehaviour
{
    int codeLength;
    int placeInCode;

    public string code = "";
    public string attemptedCode;
    public GameObject textdisplay;

    public Transform toOpen;

    private void Start()
    {
        codeLength = code.Length;
        
        
    }
    public void Update()
    {
        textdisplay.GetComponent<TextMesh>().text = attemptedCode;
    }

    void CheckCode()
    {
        if(attemptedCode == code)
        {
            StartCoroutine(Open());
        }
        else
        {
            Debug.Log("Wrong Code");
        }
    }

    IEnumerator Open()
    {
        toOpen.Rotate(new Vector3(0, -100, 0), Space.World);

        yield return new WaitForSeconds(15);

        toOpen.Rotate(new Vector3(0, 100, 0), Space.World);


    }

   
    public void SetValue (string value)
    {
        placeInCode++;

        if(placeInCode <= codeLength)
        {
            attemptedCode += value;
        }

        if(placeInCode == codeLength)
        {
            CheckCode();
            
            attemptedCode = "";
            placeInCode = 0;
        }
    }


}
