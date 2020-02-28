using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Vidas : MonoBehaviour {

    public static int vidas = 3;

    public Text textoVidas;
    public Pelota pelota;
    public Barra barra;

    public GameObject gameOver;
    public SiguienteNivel siguienteNivel;

    public SonidosFinPartida sonidosFinPartida;

	// Use this for initialization
	void Start () {
        ActualizarMarcadorVidas();
	}

    void ActualizarMarcadorVidas()
    {
        textoVidas.text = "Vidas: " + Vidas.vidas;
    }

    public void PerderVida()
    {
        if (Vidas.vidas <= 0) return;

        Vidas.vidas--;
        ActualizarMarcadorVidas();

        if (Vidas.vidas <= 0)
        {
            //Monstraremos Game Over
            gameOver.SetActive(true);
            sonidosFinPartida.GameOver();

            pelota.DetenerMovimiento();
            pelota.gameObject.SetActive(false);
            barra.enabled = false;
            //barra.SetActive(false);

            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();
        }
        else
        {
            barra.Reset();
            pelota.Reset();
        }      
        
    }
}
