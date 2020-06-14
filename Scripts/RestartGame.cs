using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("SampleScene");
            SkoHesaplama.skorSayisi = 0;
        }
    }



}
