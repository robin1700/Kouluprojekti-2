using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{

    public static int course1 = 0;
    public static int remCourse1 = 8;
    public Text CurrentStrokes;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        //CurrentStrokes.GetComponent<Text>().text = course1.ToString() + "   Strokes\n \n a = Left \n d = Right \n z = Increase Power \n c = Decrease Power";
        //CurrentStrokes.GetComponent<Text>().text = course1.ToString() + "     " + remCourse1.ToString();
    }
}
