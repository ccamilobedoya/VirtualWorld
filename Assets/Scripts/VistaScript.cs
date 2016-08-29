using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class VistaScript : MonoBehaviour {


	public float anchoVision;
	public float distanciaVision;
	public int cantidadRaycast;
	public List<GameObject> objetosVisibles;
	public List<GameObject> objetosVistos;

	void Start () {
		
	}
	

	void Update () {
		Raycasting ();
	}

	void Raycasting () {
		objetosVisibles.Clear ();
		float movimientoMirar = (anchoVision * 2) / cantidadRaycast;
		for (int i = 0; i < cantidadRaycast; i++) {
			Vector3 posDireccion = transform.position + ((transform.forward * distanciaVision) + (transform.right * (anchoVision - (movimientoMirar * i))));
			Debug.DrawRay (transform.position, posDireccion - transform.position, Color.magenta);
			RaycastHit hit;
			if (Physics.Raycast (transform.position, posDireccion - transform.position, out hit , distanciaVision)) {
				objetosVisibles.Add (hit.transform.gameObject);
				if (!objetosVistos.Contains (hit.transform.gameObject)) {
					objetosVistos.Add(hit.transform.gameObject);
				}
			}
		}
	}


}
