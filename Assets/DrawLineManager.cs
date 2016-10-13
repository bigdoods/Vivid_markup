using UnityEngine;
using System.Collections;

public class DrawLineManager : MonoBehaviour {

public SteamVR_TrackedObject trackedObj;

private GraphicsLineRenderer currLine;

private int numClicks = 0;

//set line color at the start and at the end
private Color c1 = Color.red;
private Color c2 = Color.red;

void Update () {
	SteamVR_Controller.Device device = SteamVR_Controller.Input((int)trackedObj.index);
	if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = new GameObject();
			go.AddComponent<MeshFilter>();
			go.AddComponent<MeshRenderer>();

			currLine = go.AddComponent<GraphicsLineRenderer> ();
			//currLine.material = new Material(Shader.Find("Particles/Additive"));
			//currLine.SetColors(c1, c2);

			currLine.setWidth(.1f); // Adjust line width here

			numClicks = 0;

		} else if (device.GetTouch (SteamVR_Controller.ButtonMask.Trigger)) {
			currLine.AddPoint(trackedObj.transform.position);
			numClicks++;
			}
	}
}
