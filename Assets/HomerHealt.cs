using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomerHealt : MonoBehaviour
{
    // Start is called before the first frame update}
    public SpriteRenderer player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (QuitarVida.cantidad_vida < 0) {
            Destroy(this.gameObject);
        }

        if (player.flipX == false) { 
        
        }
       
    }
}
