using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : ManagerScript {
	
	float timer;
	float limit = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (limit <= timer) {
			Attack ();
			timer = 0;
		}
	}

	void Attack(){
		PlayerHPminus ();
	}



}
