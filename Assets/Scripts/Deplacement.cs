using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour {
	private float Speed = 8f;
	private Vector2 DirectionDeplacement = Vector2.zero;
	private CharacterController Player;
	private Animator Anim;

	// Use this for initialization
	void Start () {
		Player = GetComponent<CharacterController>();
		Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		DirectionDeplacement.x = Input.GetAxisRaw("Horizontal");
		DirectionDeplacement.y = Input.GetAxisRaw("Vertical");
		DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);

		Player.Move (DirectionDeplacement * Speed * Time.deltaTime);

		/*if (Player.velocity.magnitude >= 0) {
			Anim.SetFloat ("SpeedVertical", Mathf.Abs (DirectionDeplacement.y));
			Anim.SetFloat ("SpeedHorizontal", Mathf.Abs (DirectionDeplacement.x));
		} */

		//Lancement de l'animation par rapport au deplacement du personnage
		if (DirectionDeplacement.x <= 0) 
			Anim.SetFloat ("SpeedGauche", Mathf.Abs (DirectionDeplacement.x));
		if (DirectionDeplacement.x >= 0)
			Anim.SetFloat ("SpeedDroite", Mathf.Abs (DirectionDeplacement.x));
		if (DirectionDeplacement.y <= 0) 
			Anim.SetFloat ("SpeedBas", Mathf.Abs (DirectionDeplacement.y));
		if (DirectionDeplacement.y >= 0)
			Anim.SetFloat ("SpeedHaut", Mathf.Abs (DirectionDeplacement.y));
		

	}
}
