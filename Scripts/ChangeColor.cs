using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update

    public float timer = 0.0f;
    private Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)//change the float value here to change how long it takes to switch.
        {
            switch (Random.Range(0, 5))
            {
                case 0:
                    {

                        Color newColor = new Color(0.9f, 0.7f, 0.9f, 1.0f);
                        renderer.material.color = newColor;
                        timer = 0;
                        break;
                    }
                case 1:
                    {
                        Color newColor1 = new Color(0.9f, 0.7f, 0.3f, 1.0f);
                        renderer.material.color = newColor1;
                        timer = 0;
                        break;
                    }
                case 2:
                    {
                        Color newColor2 = new Color(0.9f, 0.2f, 0.3f, 1.0f);
                        renderer.material.color = newColor2;
                        timer = 0;
                        break;
                    }
                case 3:
                    {
                        Color newColor3 = new Color(0.6f, 0.2f, 0.3f, 1.0f);
                        renderer.material.color = newColor3;
                        timer = 0;
                        break;
                    }
                case 4:
                    {
                        Color newColor4 = new Color(0.6f, 0.6f, 0.3f, 1.0f);
                        renderer.material.color = newColor4;
                        timer = 0;
                        break;
                    }
                case 5:
                    {
                        Color newColor5 = new Color(0.6f, 0.6f, 0.9f, 1.0f);
                        renderer.material.color = newColor5;
                        timer = 0;
                        break;
                    }

            }
        }
    }
}
