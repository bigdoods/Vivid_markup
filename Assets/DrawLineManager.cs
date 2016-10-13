using UnityEngine;
using System.Collections;

public class DrawLineManager : MonoBehaviour {

public SteamVR_TrackedObject trackedObj;

private LineRenderer currLine;

private int numClicks = 0;

//set line color at the start and at the end
private Color c1 = Color.red;
private Color c2 = Color.red;

void Update () {
	SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
	if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = new GameObject();
			currLine = go.AddComponent<LineRenderer>();
			currLine.material = new Material(Shader.Find("Particles/Additive"));
			currLine.SetColors(c1, c2);

			currLine.SetWidth(.1f , .1f); // Adjust line width here

			numClicks = 0;

		} else if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			currLine.SetVertexCount(numClicks + 1);
			currLine.SetPosition(numClicks, trackedObj.transform.position); //3d position of controller at any point in time
			numClicks++;
			}
	}
}
