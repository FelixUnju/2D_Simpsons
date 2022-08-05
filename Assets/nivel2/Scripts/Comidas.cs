using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comidas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objetivo;
    public float velocidad = 1.0f;
    int pos;
    void Start()
    {
        objetivo = GameObject.FindGameObjectsWithTag("abajo");
        pos = Random.Range(0,7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, objetivo[pos].transform.position, velocidad * 3 * Time.deltaTime);
        if (transform.position == objetivo[pos].transform.position)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDrag()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}
