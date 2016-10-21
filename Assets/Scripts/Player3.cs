using UnityEngine;
using System.Collections;

public class Player3 : MonoBehaviour {
	
	public GameObject ObjPlayer;
	public GameObject ObjPlayer2;

	private Player2 PlayerTx;
	private Player PlayerT;


	// Use this for initialization
	void Start () {
		PlayerT = ObjPlayer.GetComponent<Player>();
		PlayerT.DetractHealth (10);
		PlayerTx = ObjPlayer2.GetComponent<Player2>();
		PlayerTx.ScreamTime (5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
