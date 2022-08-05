using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] comidas;
    public GameObject[] puntos_spawn;
    void Start()
    {
        InvokeRepeating("SpawnObject", 2.0f, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObject()
    {
        int i = Random.Range(0, 9);
        int j = Random.Range(0, 7);
        GameObject aux = Instantiate(comidas[i], puntos_spawn[j].transform.position, Quaternion.identity);
    }
}
