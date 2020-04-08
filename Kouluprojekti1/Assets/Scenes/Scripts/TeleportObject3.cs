using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject SpawnableObj;
    public GameObject DestroyObj;
    public AudioSource Audio;

      
    private void OnTriggerEnter(Collider other)

    {

        if (other.tag == "Golf")

        {
            SpawnableObj.SetActive(true);
            Destroy(DestroyObj);
            Audio.Play();

        }

    }
   
} 



