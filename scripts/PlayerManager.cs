using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score = 0;
    public AudioClip ducksound;

    private AudioSource audioSource;
    public AudioClip rockCollisionSound;



    public GameObject deathpanel;

    private Rigidbody playerRigidbody;

    private int highestScore = 0;
    private bool isDead = false;

    public ShakeController shakeController;


    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ducksound;
        deathpanel.SetActive(false);
        playerRigidbody = GetComponent<Rigidbody>();
        shakeController = Camera.main.GetComponent<ShakeController>();


    }


    void Update()
    {
        if (isDead)
        {
            return;
        }

        UpdateScoreText();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isDead)
        {
            return;
        }

        if (other.gameObject.CompareTag("Ducks"))
        {
            print("+1 scoreduck");
            if (ducksound != null)
            {
                audioSource.Play();
                score++;

                UpdateScoreText();

                Destroy(other.gameObject);
            }
        }

        else if (other.gameObject.CompareTag("Rocks"))
        {
            print("tasa carpttin");

            if (rockCollisionSound != null)
            {
                audioSource.PlayOneShot(rockCollisionSound);
            }

            shakeController.StartShake();
            deathpanel.SetActive(true);
            playerRigidbody.constraints = RigidbodyConstraints.FreezeAll;
            isDead = true;







        }





    }
    private void UpdateScoreText()
    {
        scoreText.text = "Ducks: " + score;
        if (score > highestScore)
        {
            highestScore = score;
            PlayerPrefs.SetInt("HighestScore", highestScore);
        }


    }
}
