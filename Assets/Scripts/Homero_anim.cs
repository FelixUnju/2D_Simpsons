using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homero_anim : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.tag == "sonido_bien")
        {
            anim.SetTrigger("jump");
        }
        else {
            anim.SetTrigger("mal");
        }
    }

}
