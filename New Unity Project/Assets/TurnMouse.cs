using UnityEngine;
using System.Collections;

public class TurnMouse : MonoBehaviour {

	void Update()
	{
		if (Input.GetAxis("Mouse X") != 0)
			this.transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
		if (Input.GetAxis("Mouse Y") != 0)
			this.transform.Rotate(Vector3.right * Input.GetAxis("Mouse Y"));
	}
}
