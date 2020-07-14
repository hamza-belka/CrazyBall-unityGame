using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayPlayGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
    public void Gomainmenu()
    {
        SceneManager.LoadScene("menu");

    }
}
