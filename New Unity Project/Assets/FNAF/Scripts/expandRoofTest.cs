using UnityEngine;
using System.Collections;

public class expandRoofTest : MonoBehaviour {

	void Start()
	{
		Vector3 temp = new Vector3 (0, 39.5f, 0);
		transform.localScale += temp;
		RenderSettings.ambientIntensity = 0;
	}
}
