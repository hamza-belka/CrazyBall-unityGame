using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Scorevalue=0;
    public Text scoret;

    void Start()
    {
        scoret.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoret.text = ""+ Scorevalue;
    }
}
