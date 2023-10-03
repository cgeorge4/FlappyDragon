using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class DragonController : MonoBehaviour
{
    public AudioClip crash;
    public AudioClip flap;
    public AudioClip point;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    Rigidbody myBod;
    Animator myAnim;
    AudioSource myAudioSource;
   public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAudioSource = GetComponent<AudioSource>();
        myBod = GetComponent<Rigidbody>();
        myBod.velocity = new Vector3(10, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;

        if(Input.GetButtonDown("Jump"))
        {
            myBod.velocity = new Vector3(10, 15, 0);
            myAnim.SetBool("Flap", true);
            myAudioSource.PlayOneShot(flap);
        } 
        else {
            myAnim.SetBool("Flap", false);
        }
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        myAudioSource.PlayOneShot(crash);
        Time.timeScale = 0;
        gameOverText.text = "Game Over";
        //gameOver.setActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        myAudioSource.PlayOneShot(point);
        score++;
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject column = other.gameObject;
        GameObject g = Instantiate(column);
        g.gameObject.name = "Column" + (score+1);
        g.transform.position = new Vector3(column.transform.position.x+40, Random.Range(0, 10), 0);
    }
}