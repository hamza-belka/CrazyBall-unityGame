using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fingamelineScript : MonoBehaviour
{
    AudioSource audioSource;
    public float waittime = 3f;
    public GameObject PauseScreen;
    bool GamePaused;
    void Start()
    {
        GamePaused = false;
        audioSource = GetComponent<AudioSource>();
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waittime);
        // SceneManager.LoadScene("menu");
        GamePaused = true;
        PauseScreen.SetActive(true);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("block"))
        {
            audioSource.Play();
            GamePaused = true;
            PauseScreen.SetActive(true);
        }








    }
    }


