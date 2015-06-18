using UnityEngine;
using System.Collections;

public class UpdateGO : MonoBehaviour {

	public TextMesh puntos;
	public Puntuacion puntuacion;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable(){
		puntos.text = puntuacion.puntos.ToString ();
	}
}
