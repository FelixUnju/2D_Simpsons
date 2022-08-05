using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetodosUI : MonoBehaviour
{

    public void cambioDeNivel(string nivel) {
        SceneManager.LoadScene(nivel);
    }
}