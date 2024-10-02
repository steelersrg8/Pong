using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWallCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {

		gameManager.score1 = gameManager.score1 + 1;
		Debug.Log ("Collision!!!!");
		other.gameObject.SendMessage("resetBall",0.5f,SendMessageOptions.RequireReceiver);

	}
}
