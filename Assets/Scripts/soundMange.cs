using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMange : MonoBehaviour
{
    public static AudioClip hitsound, gameoversound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        hitsound = Resources.Load<AudioClip>("hitsound");
        gameoversound = Resources.Load<AudioClip>("gameoversound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playsound(string clip )
    {
        switch (clip)
        {
            case "hitsound":
                audioSource.PlayOneShot(hitsound);
                break;
            case "gameoversound":
                audioSource.PlayOneShot(gameoversound);
                break;


        }

    }
}
