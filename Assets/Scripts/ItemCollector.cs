using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melon = 0;
    [SerializeField] private Text scoreText;
    [SerializeField] private AudioSource melonSE;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            melonSE.Play();
            Destroy(collision.gameObject);
            melon++;
            scoreText.text = "Cherries: " + melon;
        }
    }
}
