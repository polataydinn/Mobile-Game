using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkoHesaplama : MonoBehaviour
{
    public static int skorSayisi=0;
    public Text countText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        countText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        if(collision.gameObject.tag == "Player")
        {
            skorSayisi++;
            PlayerPrefs.SetInt("Skor", skorSayisi);
            countText.text = "Skor: " + PlayerPrefs.GetInt("Skor");

        }

    }

}
