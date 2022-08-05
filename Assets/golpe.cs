using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpe : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public GameObject punch;
    public SpriteRenderer player;
    public Transform pos_derecha;
    public Transform pos_izquierda;
    void Start()
    {
        punch.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            anim.SetBool("golpe", true);
            punch.SetActive(true);
            
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("golpe", false);
            punch.SetActive(false);
        }

        if (player.flipX == false)
        {
            punch.transform.position = pos_derecha.position;
        }
        if (player.flipX == true)
        {
            punch.transform.position = pos_izquierda.position;
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            player.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.flipX = true;
        }
    }

 
}
