using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySonidos : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource primer_sonido,segund_sonido;
    void Start()
    {
        primer_sonido.Play();
        segund_sonido.PlayDelayed(primer_sonido.clip.length+3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
