using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] puntos_choque;
    public float speed = 1.0f;
    public float force = 1.0f;
    public AudioSource sound_bien;
    public AudioSource sound_mal;
    public AudioSource sound_background;
    public GameObject score_final;
    int i;
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntos_choque[i].position, 3 * speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "dona") {
            Time.timeScale = 0.0f;
            score_final.SetActive(true);
            sound_background.Stop();
        }

        if (collision.gameObject.tag == "sonido_bien")
        {
            sound_bien.Play();
        }
        else {
            sound_mal.Play();
            i++;
        }
    }
}
