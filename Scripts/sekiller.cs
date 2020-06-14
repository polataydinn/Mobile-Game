using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sekiller : MonoBehaviour
{
    public static int patlasinmiPatlamasinmi = 0;
   

    private void Start()
    {
        patlasinmiPatlamasinmi = 0;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
             patlasinmiPatlamasinmi = 1;
        }
    }
}
