using UnityEngine;
using System.Collections;

public class DrawLineManager : MonoBehaviour {

public SteamVR_TrackedObject trackedObj;

private LineRenderer currLine;

private int numClicks = 0;

void Update () {
	SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
	if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = new GameObject ();
			currLine = go.AddComponent<LineRenderer> ();

			currLine.SetWidth(.1f , .1f);

			numClicks = 0;

		} else if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			currLine.SetVertexCount(numClicks + 1);
			currLine.SetPosition(numClicks, trackedObj.transform.position); //3d position of controller at any point in time
			numClicks++;
			}
	}
}
