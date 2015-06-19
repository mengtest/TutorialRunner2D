using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public float velocidad = 0f;
	private bool start = false;
	private float tiempoInicio = 0f;
	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeRun");
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeHaMuerto");
	}
	
	// Update is called once per frame
	void Update () {
		if (start == true) {
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (((Time.time - tiempoInicio) * velocidad) % 1, 0);
		}
	}

	void PersonajeHaMuerto(){
		start = false;
	}
	void PersonajeRun(){
		start = true;
		tiempoInicio = Time.time;
	}
}
