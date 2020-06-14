using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MapMaker : MonoBehaviour
{
    private ParticleSystem particleSystem;
    public GameObject[] sekil;
    public float sekilSayisi;
    public float sekilAraligi;
    public float eksenx;
    private float randomSayi;
    public List<GameObject> listeOlusturma; // önceki şekli silmek için

    
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        for(int i=0; i<sekilSayisi; i++)
        {
            createMap();
        }
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > ((eksenx+8) - sekilAraligi * sekilSayisi)){
            createMap();
            Destroy(listeOlusturma[0]);
            listeOlusturma.RemoveAt(0);
        }    
        
    }


   void createMap()
    {
        randomSayi = Random.Range(1.30f, -2.22f);
        GameObject objeler;
        objeler = Instantiate(sekil[0].gameObject);
        objeler.transform.position =new Vector3(eksenx, randomSayi,-20f);
        eksenx += sekilAraligi;
        listeOlusturma.Add(objeler);
        

    }
}
