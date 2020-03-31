using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public static SceneChange sceneChange;
    // Start is called before the first frame update
    bool gamestart;
    public int scene1;
       
    void Awake()
    {
        if (!gamestart)
        {
            sceneChange = this;
            SceneManager.LoadSceneAsync(scene1, LoadSceneMode.Additive);
            gamestart = true;
        }
    }

    // Update is called once per frame
    public void UnloadScene(int scene)
    {
        StartCoroutine(Unload(scene));
    }

    IEnumerator Unload(int scene)
    {
        yield return null;
        SceneManager.UnloadScene(scene);
    }

}
