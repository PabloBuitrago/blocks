using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Puntos : MonoBehaviour {

    public static int puntos = 0;

    public Text textoPuntos;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;

    public SiguienteNivel siguienteNivel;

    public Pelota pelota;
    public Barra barra;

    public Transform contenedorBloques;

    public SonidosFinPartida sonidosFinPartida;

	// Use this for initialization
	void Start () {
        ActualizarMarcadorPuntos();
	}

    void ActualizarMarcadorPuntos()
    {
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }

    public void GanarPuntos()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            pelota.gameObject.SetActive(false);
            sonidosFinPartida.NivelCompletado();
            barra.enabled = false;

            if (siguienteNivel.EsUltimoNivel())
            {
                juegoCompletado.SetActive(true);
            }
            else
            {
                nivelCompletado.SetActive(true);
            }

            siguienteNivel.ActivarCarga();
        }        
    }
}
