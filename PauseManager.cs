using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausepanel;



    void Update()
    {
    }




    public void Pause()
    {

        pausepanel.SetActive(true);
        Time.timeScale = 0;


    }

    public void Devamke()
    {

        pausepanel.SetActive(false);
        Time.timeScale = 1;


    }

    public void tekraroyna()
    {
        SceneManager.LoadScene(1);

    }

    public void Menuyegiris()
    {
        SceneManager.LoadScene(0);
    }
}
