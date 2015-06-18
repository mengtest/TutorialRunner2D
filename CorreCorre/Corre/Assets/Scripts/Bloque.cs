using UnityEngine;
using System.Collections;

public class Bloque : MonoBehaviour {

	private bool choque = false;
	public int valor_puntos = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){

		if (choque == false && collision.gameObject.tag == "Player") {
			choque = true;
			NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos",valor_puntos);
		}

	}
}
