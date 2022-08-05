using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objetos01;
    public Transform spawn_obj;
    public Transform objetivo;
    public float speed = 1.0f;
    public Text time_score;
    public Text time_score_final;
    float time = 0.0f;
    int i;
    public AudioSource click;
    void Start()
    {
  
        i = 0;
        foreach (GameObject obj in objetos01)
        {
            obj.transform.position = spawn_obj.position;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            click.Play();
            click.Play();
        }
        objetos01[i].transform.position = Vector2.MoveTowards(objetos01[i].transform.position, objetivo.position, 3 * speed * Time.deltaTime);
        if (objetos01[i].transform.position == objetivo.position) {
            objetos01[i].transform.position = spawn_obj.position;
            objetos01[i].SetActive(true);
            i = Random.Range(0,4);
            Debug.Log("cambio: "+ i);
        }

        time += Time.deltaTime;
        time_score.text = time.ToString("000");
        time_score_final.text = time.ToString("000");
    }
}
