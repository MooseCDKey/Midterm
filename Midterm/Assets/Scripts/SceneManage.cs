using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void PlayG()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitG()
    {
        Application.Quit();
    }

    public void PlaySFromMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlaySAfterG()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //used after maze is done
    }

    public void ReturnToM()//used on statistics scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
