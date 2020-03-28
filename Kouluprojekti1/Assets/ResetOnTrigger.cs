using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}
