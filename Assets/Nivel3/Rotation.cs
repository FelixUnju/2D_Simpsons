using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f;
    public float speed2 = 1.0f;
    public Transform[] pos;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.localEulerAngles;
        rotation.z += Time.deltaTime * - speed * 10;
        transform.localEulerAngles = rotation;
    }
}
