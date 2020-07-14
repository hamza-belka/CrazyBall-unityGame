using UnityEngine;

public class BallReturn : MonoBehaviour
{
    private BallLauncher ballLauncher;


    private void Awake()
    {
        ballLauncher = FindObjectOfType<BallLauncher>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            ballLauncher.ReturnBall();
            collision.gameObject.SetActive(false);

        
    }
}