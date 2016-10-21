using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	//method one
	public Player something;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (something.Inithealth == 0) {
			print (" the other player has died");
		}

	}

	public void ScreamTime ( float flo ){
		print ("I only know how to do this");
	}
}
