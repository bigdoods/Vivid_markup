using UnityEngine;
using System.Collections;
//using Valve.VR;

public class CycleTest2 : MonoBehaviour 
{
	public GameObject[] objBunch;

	// SteamVR_TrackedObject controller;

	int bunchPos;


	void Awake ()
	{
		//print (objBunch[bunchPos]);
		//print (objBunch[1]);
		//print (objBunch[2]);
		//print (bunchPos);//controller = GetComponent<SteamVR_TrackedObject>();
	}

	void Update ()
	{
		//var device = SteamVR_Controller.Input ((int)controller.index);
		//if (device.GetPressDown (SteamVR_Controller.ButtonMask.ApplicationMenu)) 

		if (Input.GetKeyDown (KeyCode.Space))

		{
			print (" I have got space touch");
			//for (int i = 0; i <= 10 ; i++)
			//{
			//	print (objBunch[i]);
			//} 
			//else
			//{
			//	bunchPos = 0;
			//}
		}

	}

}
