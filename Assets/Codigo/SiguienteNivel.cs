using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SiguienteNivel : MonoBehaviour {

    public string nivelACargar;
    public float retraso;

    public void ActivarCarga()
    {
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel()
    {
        if (!EsUltimoNivel())
        {
            Vidas.vidas++;
        }
        SceneManager.LoadScene(nivelACargar);
    }

    public bool EsUltimoNivel()
    {
        /*if(nivelACargar == "Portada")
        {
            return true;
        }
        else
        {
            return true;
        }*/

        return nivelACargar == "Portada";     
    }
}
