using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using UnityEngine.SceneManagement;

public class GameBegin : MonoBehaviour
{

    public float delaytime = 10f;

    public AudioClip ducksound;
    public AudioSource ducksource;

    



    private void Start()
    {
       
       
       
    }

    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseGame()
    {
        
        Application.Quit();
    }
    public void PlayDuckSound()
    {
        ducksource.Play();
    }



}
