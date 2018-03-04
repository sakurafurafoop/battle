using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScript : MonoBehaviour{

	int PlayerHP = 5;
	int EnemyHP = 5;
	public Text playerHP;
	public Text enemyHP;
	public bool Playerbarrier = false;//バリアしているか否か
	float barrierLimit = 300.0f;//バリアが効く時間
	float barriertimer = 0;

	// Use this for initialization
	void Start () {
		
	}

	public void PlayerHPminus(){
		if (Playerbarrier == true) {
			Debug.Log ("Barrier");
		}
		
		if (Playerbarrier == false) {
			Debug.Log ("NOBarrier");
			PlayerHP -= 1;
			//Debug.Log (PlayerHP);
			playerHP.text = "PlayerHP:" + PlayerHP.ToString ();

			if (PlayerHP <= 0) {
				Debug.Log ("Loss");
				PlayerLoss ();
			}
		}
	}

	public void EnemyHPminus(){
		EnemyHP -= 1;
		enemyHP.text = "EnemyHP:" + EnemyHP.ToString ();
		//Debug.Log (EnemyHP);
		if (EnemyHP <= 0) {
			PlayerWin ();
		}
	}
	
	public void Barrier(){
		barriertimer += Time.deltaTime;
		if (Playerbarrier == false) {
			Playerbarrier = true;
			if (barriertimer >= barrierLimit) {
				Playerbarrier = false;
			}
		}
	}


	void PlayerWin(){
		SceneManager.LoadScene ("Win");
	}

	void PlayerLoss(){
		SceneManager.LoadScene ("Loss");
	}
}
