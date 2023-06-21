using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonetici : MonoBehaviour
{
    
    public GameObject elma;
    
  
    void Start()
    {

        InvokeRepeating("elma_ekle", 0.0f,1.0f);




    }



    void elma_ekle()
    {
        float rast = Random.Range(-5f, 13f);
        GameObject yeni_elma = Instantiate(elma, new Vector3(rast, 9, -7), Quaternion.identity);

    }
    void Update()
    {
        
    }
}
