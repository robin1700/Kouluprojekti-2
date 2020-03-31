using UnityEngine;
using System.Collections;

public class ThrowObject : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    public AudioClip[] soundToPlay;
    private AudioSource audio;
    public int dmg;
    private bool touched = false;
    RaycastHit hit;
    void Start()
    {
      //  audio = GetComponent<AudioSource>();
    }

    void Update()
    {
       
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1) && hit.transform.GetComponent<Rigidbody>()  )
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetButtonDown("use"))
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    beingCarried = false;
                    GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                RandomAudio();
                }
                else if (Input.GetMouseButtonDown(1))
                {
                GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                beingCarried = false;
                }
            }
        }
    void RandomAudio()
    {
        if (audio.isPlaying){
            return;
                }
        audio.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
        audio.Play();

    }
   void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
    }