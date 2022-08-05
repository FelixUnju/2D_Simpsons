using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    // Start is called before the first frame update
   
    public static int cantidad_vida = 20;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cantidad_vida -= 5;
        Debug.Log("SACAR VIDA");
    }
}
