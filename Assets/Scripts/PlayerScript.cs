using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : ManagerScript {
	public Text Attacktext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Attack(){
		Debug.Log ("Attack");
		Attacktext = GetComponent<Text> ();
		//particle = GetComponent<Particle> ();
		EnemyHPminus();
	}


		
}
