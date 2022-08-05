using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRun : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform posA, posB;
    public float speed = 1.0f;
    Transform aux;
    public SpriteRenderer sprite;
    public bool alto = true;
    void Start()
    {
        aux = posA;
    }

    // Update is called once per frame
    void Update()
    {
        if (alto)
        {
            transform.position = Vector2.MoveTowards(transform.position, aux.position, speed * 3 * Time.deltaTime);
        }
        if (transform.position == posA.position)
        {
            aux = posB;
            sprite.flipX = true;
        }

        if (transform.position == posB.position)
        {
            aux = posA;
            sprite.flipX = false;
        }
    }
}
