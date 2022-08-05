using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] comidas;
    public GameObject[] puntos_spawn;
    public static int puntuacion;
    public Text txt_puntos;
    public Text txt_tiempo;
    float tiempo;
    public GameObject uiScore;
    public Text txt_puntcion_final;
    void Start()
    {
        puntuacion = 0;
        tiempo = 10.0f;
        InvokeRepeating("SpawnObject", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacion < 0){
            puntuacion = 0;
        }
        txt_puntos.text = puntuacion.ToString("000");
        tiempo-=Time.deltaTime;
        txt_tiempo.text = tiempo.ToString("00");
        if (tiempo <= 0.0f) {
            uiScore.SetActive(true);
            txt_puntcion_final.text = puntuacion.ToString("00");
            Time.timeScale = 0;
        }
    }

    public void SpawnObject (){
        int i = Random.Range(0,9);
        int j = Random.Range(0,9);
        GameObject aux = Instantiate(comidas[i], puntos_spawn[j].transform.position, Quaternion.identity);
    }
}
