using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Object : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public GameObject objetivo;
    void Start()
    {
        velocidad = Random.Range(2.0f,5.0f);
        objetivo =  GameObject.FindGameObjectWithTag("Homero");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D ()
    {
       if (this.gameObject.tag == "sonido_bien"){
            GameObject.Find("bien").GetComponent<AudioSource>().Play();
            Manager.puntuacion +=10;
       }else
       {
            GameObject.Find("mal").GetComponent<AudioSource>().Play();
            Manager.puntuacion -=3;
        }
        Destroy(this.gameObject);
    }

    void OnMouseDown()
    {
        Destroy(this.gameObject);
        GameObject.Find("tap").GetComponent<AudioSource>().Play();
    }
}
