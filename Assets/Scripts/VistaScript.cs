using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum cosas {
	algo = 1,
	algo2 = 2
}

public class VistaScript : MonoBehaviour {

	public cosas cositas;
	public float anchoVision;
	public float distanciaVision;
	public int cantidadRaycast;
//	public List<CaracteristicaScript> objetosVisibles;
//	public List<CaracteristicaScript> objetosVistos;

	public bool raycastInmovil;
	public Transform[] apuntadoresMoviles;

//	public DudaCaracteristicaScript carac;



	void Start () {
//		objetosVisibles = new List<CaracteristicaScript>();
		//if (cositas == cosas.algo) 
	}
	

	void Update () {
		if (raycastInmovil)
			Raycasting ();
		else
			RaycasteoMovil ();
	}

	void Raycasting () {/*
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
		}*/
	}

	void RaycasteoMovil () {
//		objetosVisibles.Clear ();
		RaycastHit hit;
		for (int i = 0; i < apuntadoresMoviles.Length; i++) {
			
			Debug.DrawRay (transform.position, apuntadoresMoviles[i].position - transform.position, Color.magenta);

			if (Physics.Raycast (transform.position, (apuntadoresMoviles[i].position - transform.position).normalized, out hit, Vector3.Distance(apuntadoresMoviles[i].position, transform.position))) {
//				objetosVisibles.Add (carac.ObtenerCaracteristica(Vector3.Distance(apuntadoresMoviles[i].position, transform.position), hit.transform));
				/*if (!objetosVistos.Contains (hit.transform.gameObject)) {
					objetosVistos.Add(hit.transform.gameObject);

				}*/
			}
		}
	}


}
