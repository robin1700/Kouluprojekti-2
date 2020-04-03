using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    
    public float zForce = 0;
    public Camera maincam;
    public Transform aimarrow;
    public float yScale = 1;


    void Start()
    {
        
    }

    
    void Update()
    {
                // Pallon ohjaaminen
        if (Input.GetKeyDown("z"))
        {
            zForce += 200;
            yScale += 1;
            if (zForce > 4400)
            {
                zForce = 4400;
                yScale = 22;
            }
                // Skaalataan nuolen kokoa voiman näyttämiseksi
            aimarrow.GetComponent<Transform>().localScale = new Vector3(1, yScale, 1);
        }


                // Pallon ohjaaminen
        if (Input.GetKeyDown("c"))
        {
            zForce -= 200;
            yScale -= 1;
            if (zForce < 0)
            {
                zForce = 0;
                yScale = 1;
            }
                    // Skaalataan nuolen kokoa voiman näyttämiseksi
            aimarrow.GetComponent<Transform>().localScale = new Vector3(1, yScale, 1);
        }


        if (Input.GetKeyDown("a"))
        {
            transform.Rotate(0, -10, 0);
        }

        if (Input.GetKeyDown("d"))
        {
            transform.Rotate(0, 10, 0);
        }

                // Kamera seuraa palloa
        maincam.GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity;
    }


    void OnMouseDown()
        {
                    // Klikataan palloa ja saadaan se liikkelle
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, zForce);
                    // Piilottaa nuolen
            aimarrow.GetComponent<Renderer>().enabled = false;
                    // Lyöntien laskenta
            GameFlow.course1 += 1;
            GameFlow.remCourse1 -= 1;
                    // Pysäyttää pallon
            StartCoroutine(stopball());
        }


    void OnTriggerEnter(Collider other)
    {  
                // Rata suoritettu
        Debug.Log("course cleared");
        if (other.name == "Cup")
        {
                    // Mitä tapahtuu kun rata suoritettu?
            //SceneManager.LoadScene(" TÄNNE LADATTAVAN SCENEN NIMI ");
        }
    }


    IEnumerator stopball()
        {
                    // 5 Sekunnin kuluttua lyönnistä pallo pysähtyy
            yield return new WaitForSeconds(5);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            yield return new WaitForSeconds(.1f);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    // Resettaa pallon orientaatio
            transform.localEulerAngles = new Vector3(0, 0, 0);
                    // Tuodaan nuoli takaisin näkyviin
            aimarrow.GetComponent<Renderer>().enabled = true;
        }
}

