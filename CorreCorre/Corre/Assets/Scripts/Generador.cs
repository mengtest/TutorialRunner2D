using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
	public float tiempoMin = 2f;
	public float tiempoMax = 3f;
	private bool fin = false;
	void Start () {
		//Generar ();
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeRun");
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeHaMuerto");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void PersonajeHaMuerto(){
		fin = true;
	}
	void PersonajeRun(Notification notificacion){
		Generar (); 
	}

	void Generar(){
		if (fin != true) {
			Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
			Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
		}
	}
}
