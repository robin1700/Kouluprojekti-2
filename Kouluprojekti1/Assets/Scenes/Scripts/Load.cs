using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    public int scene;
    bool loaded;

    private void OnTriggerEnter()
    {
        if (!loaded)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Additive);
            loaded = true;
        }
    }

}
