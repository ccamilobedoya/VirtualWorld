using UnityEngine;
using System.Collections;

public class CaracteristicaScript : MonoBehaviour {

	public int id;
	public string nombre;
	public Vector3 posicion;

	void Start () {
		id = gameObject.GetInstanceID();
		nombre = gameObject.name;
		posicion = transform.position;
	}
	

	void Update () {
	
	}
}
