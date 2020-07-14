using System;
using TMPro;
using UnityEngine;

public class Block : MonoBehaviour
{
     AudioSource
 audioSource;

    private int hitsRemaining = 5;

    private SpriteRenderer spriteRenderer;
    private TextMeshPro text;

    public GameObject destroyEffect;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Awake()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();
        text = GetComponentInChildren<TextMeshPro>();
        UpdateVisualState();
    }

    private void UpdateVisualState()
    {
        text.SetText(hitsRemaining.ToString());
        if (hitsRemaining < 5)

            spriteRenderer.color = Color.Lerp(Color.white, Color.red, hitsRemaining / 10f);
        else if (hitsRemaining > 5 && hitsRemaining < 8)
        {
            spriteRenderer.color = Color.Lerp(Color.red, Color.yellow, hitsRemaining / 10f);
        }
        else if (hitsRemaining > 8 && hitsRemaining < 12)
        {
            spriteRenderer.color = Color.Lerp(Color.yellow, Color.green, hitsRemaining / 10f);
        }
        else if (hitsRemaining > 12 && hitsRemaining < 17)
        {
            spriteRenderer.color = Color.Lerp(Color.green, Color.blue, hitsRemaining / 10f);
        }
        else if (hitsRemaining > 17 && hitsRemaining < 25)
        {
            spriteRenderer.color = Color.Lerp(Color.blue, Color.cyan, hitsRemaining / 10f);
        }
        else if (hitsRemaining > 25 && hitsRemaining < 30)
        {
            spriteRenderer.color = Color.Lerp(Color.cyan, Color.gray, hitsRemaining / 10f);
        }
    }



private void OnCollisionEnter2D(Collision2D collision)
    {
        

        hitsRemaining--;
        score.Scorevalue++;
        audioSource.Play();
        if (hitsRemaining > 0)
            UpdateVisualState();
        else
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }



    }

   

    internal void SetHits(int hits)
    {
        hitsRemaining = hits;
        UpdateVisualState();
    }
}