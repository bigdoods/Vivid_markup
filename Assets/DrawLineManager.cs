using UnityEngine;
using System.Collections;

public class DrawLineManager : MonoBehaviour {

	public Material lMat;

	public SteamVR_TrackedObject TrackedObj; 

	private MeshLineRenderer currLine;

	private int numClicks = 0;

	private GameObject meshes;

	void Update () {
		SteamVR_Controller.Device device = SteamVR_Controller.Input((int)TrackedObj.index);
		if (device.GetTouchDown (SteamVR_Controller.ButtonMask.Trigger)) {
			GameObject go = new GameObject (); 
			go.AddComponent<MeshFilter> ();
			go.AddComponent<MeshRenderer> ();
			go.AddComponent<MeshCollider> ();
			currLine = go.AddComponent<MeshLineRenderer> ();
			currLine.lmat = new Material (lMat);
			currLine.setWidth (.1f);
			currLine.tag = "MarkUp";
		} else if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) { 
			currLine.AddPoint (TrackedObj.transform.position);
			numClicks++;
			//need to add markup tag to created objects
		} else if (device.GetTouchUp (SteamVR_Controller.ButtonMask.Trigger)) { 
			numClicks = 0;
			currLine = null;
		} else if (device.GetPressDown (SteamVR_Controller.ButtonMask.ApplicationMenu)) {
			meshes = GameObject.FindWithTag ("MarkUp");
			Destroy (meshes);
		}
			if (currLine != null){ 
				currLine.lmat.color = ColorManager.Instance.GetCurrentColor();
			}
		}
}
