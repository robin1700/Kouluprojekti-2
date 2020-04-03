using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetOnTrigger : MonoBehaviour
{
   // Start is called before the first frame update
    Vector3 originalposSphere;
    Vector3 originalposMaze;
    public Quaternion rotationMaze;
    public GameObject Sphere;
    public GameObject Maze;

    private void Start()
    {
        originalposSphere = new Vector3(Sphere.transform.position.x, Sphere.transform.position.y, Sphere.transform.position.z);
        originalposMaze = new Vector3(Maze.transform.position.x, Maze.transform.position.y, Maze.transform.position.z);
        rotationMaze = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
          // Sphere.transform.position = originalposSphere;
            Maze.transform.position = originalposMaze;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationMaze, Time.time * 1);
            
        }
        if (Input.GetKey(KeyCode.R))
        {
            // Sphere.transform.position = originalposSphere;
            Maze.transform.position = originalposMaze;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationMaze, Time.time * 1);
            Sphere.transform.position = originalposSphere;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Respawn"))
        {
           // Sphere.transform.position = originalposSphere;
            Maze.transform.position = originalposMaze;
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationMaze, Time.time * 1);
            Sphere.transform.position = originalposSphere;
      
            
            //Sphere.gameObject.transform.SetPositionAndRotation (new Vector3(-0.0178f, 0.0437f, -0.0825f), Quaternion.Euler(new Vector3(0, 0, 0)));
            // Maze.gameObject.transform.SetPositionAndRotation(new Vector3(1.347f, -0.721f, -2.049f), Quaternion.Euler(new Vector3(0, 0, 0)));

        }
        
    }

}
