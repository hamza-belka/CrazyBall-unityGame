using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenUi : MonoBehaviour
{
    public float resox;
    public float resoy;
    private CanvasScaler can;
    // Start is called before the first frame update
    void Start()
    {
        can = GetComponent<CanvasScaler>();
    }
    void setInfo()
    {
        resox = (float)Screen.currentResolution.width;
        resoy = (float)Screen.currentResolution.height;
        can.referenceResolution = new Vector2(resox, resoy);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
