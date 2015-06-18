using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	public int puntos = 0;
	public TextMesh marcador;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this,"IncrementarPuntos");
		marcador.text = puntos.ToString ();
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntos += puntosAIncrementar;
		//Debug.Log ("Incrementando " + puntosAIncrementar + "puntos");
		//Debug.Log ("Puntos totales: " + puntos);
		marcador.text = puntos.ToString ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
