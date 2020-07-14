using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptsplash : MonoBehaviour
{ public float waittime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waittime);
         SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
