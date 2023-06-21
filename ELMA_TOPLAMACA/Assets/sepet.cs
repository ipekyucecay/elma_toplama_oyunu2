using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class sepet : MonoBehaviour
{
    public float hiz;
    int skor = 0;
    TMPro.TextMeshProUGUI bebek_txt;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "elma") ;
        {
            skor += 10;
            Debug.Log(skor.ToString());
            bebek_txt.text = "BEBEKÝME ÖPÇÜK:X   "+skor.ToString();
            

            //float rast = Random.Range(-5f, 13f);

            // collision.gameObject.transform.position = new Vector3(rast, 9, -7);
            Destroy(collision.gameObject);
        }
    }



    
    void Start()
    {

        bebek_txt = GameObject.Find("Canvas/bebek_txt").GetComponent<TextMeshProUGUI>();
       
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))

        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }




        if (Input.GetKey(KeyCode.LeftArrow))

        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }








    }
}
