using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitScene : MonoBehaviour
{
   //used for at the end of maze
   //collide with block to exit scene
    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        if (other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.Confined; //makes cursor usable again after FPS mode
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
