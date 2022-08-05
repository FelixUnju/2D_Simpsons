using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    public Transform fin;
    public Transform spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * -speed);
        if (transform.position.x < fin.position.x)
        {
            transform.position = new Vector3(spawn.position.x, transform.position.y, transform.position.z);

        }
    }
}
