using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {

	public float velocidadMovimiento;
	public float velocidadRotacion;

	void Start () {
	
	}
	

	void Update () {
		transform.Translate (0, 0, Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime);
		transform.Rotate (0, Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime, 0);
	}
}
