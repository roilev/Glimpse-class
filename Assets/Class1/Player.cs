using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float moveSpeed = 0.1f;  

	public KeyCode rightKey = KeyCode.RightArrow;
	public KeyCode leftKey = KeyCode.LeftArrow;

	public Sprite player1;
	public Sprite player2;

	public float bottomOfScreen = -5f;

	public string sceneToSwitchToOnDeath = "GameOverScene";

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
		
		//Choose player
		if (Input.GetKeyDown(KeyCode.Tab)) {
			Debug.Log ("Changing Player");

			if (this.GetComponent<SpriteRenderer> ().sprite == player1) {
				this.GetComponent<SpriteRenderer> ().sprite = player2;
			} else if (this.GetComponent<SpriteRenderer> ().sprite == player2) {
				this.GetComponent<SpriteRenderer> ().sprite = player1;
			}
		}

		//Movements
		if (Input.GetKey(rightKey)) {
			transform.Translate(moveSpeed, 0, 0);
		}
		if (Input.GetKey(leftKey)) {
			transform.Translate(-moveSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (0, moveSpeed, 0); 

		} else if (Input.GetKeyUp (KeyCode.Space)) {
			transform.Translate (0, -moveSpeed, 0);
		}

//		if (transform.position.y < bottomOfScreen) {
//			SceneManager.LoadScene(sceneToSwitchToOnDeath);
//		}
	}
}
