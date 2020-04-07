using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unload : MonoBehaviour
{
    // Start is called before the first frame update
    public int scene;
    bool unloaded;

    private void OnTriggerEnter()
    {
        if (!unloaded)
        {
            unloaded = true;
            SceneChange.sceneChange.UnloadScene(scene);
        }
    }


}
