using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Salir : MonoBehaviour {

    public bool salir;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir)
            {
                Debug.Log("Salimos del juego");
                Application.Quit();
            }
            else
            {
                //Obsoleta
                //Application.LoadLevel("Nivel01");

                SceneManager.LoadScene("Portada");
            }
        }
	}
}
