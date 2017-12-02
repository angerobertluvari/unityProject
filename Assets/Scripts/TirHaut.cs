using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirHaut : MonoBehaviour {
	public GameObject Bullet;
	public int Force;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject Balle = Instantiate (Bullet, transform.position, Quaternion.identity) as GameObject;
			Balle.GetComponent<Rigidbody> ().velocity = Vector2.up * Force * Time.deltaTime;
			Destroy (Bullet, 1f);

		}
			
	}
}
