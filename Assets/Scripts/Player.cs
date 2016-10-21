using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int Inithealth = 30;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		DetractHealth (10);

		if (Inithealth <= 0) {
			Inithealth = 0;
			Destroy (gameObject, 1.1f);
			print ("the player has died");
		} 
		else if (Inithealth >= 15) {
			print ("you got lots of life");
		}
	}

	public void DetractHealth (int kill) {
		Inithealth -= kill;
	}
}
