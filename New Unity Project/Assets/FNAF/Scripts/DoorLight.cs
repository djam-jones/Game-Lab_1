using UnityEngine;
using System.Collections;

public class DoorLight : MonoBehaviour {

	public GameObject ObjectToActivate;

	public bool leftOpened;
	public bool rightOpened;

	private string _leftDoor = "LeftDoor";
	private string _rightDoor = "RightDoor";

	void OnMouseDown()
	{
		if (ObjectToActivate.tag == Tags.Doors)
			ActivateDoor ();
	}
	void OnMouseDrag()
	{
		if (ObjectToActivate.tag == Tags.Lights)
			ActivateLight ();
	}
	void OnMouseUp()
	{
		if (ObjectToActivate.tag == Tags.Lights)
			ObjectToActivate.GetComponent<Light> ().intensity = 0;
	}
	void ActivateLight()
	{
		ObjectToActivate.GetComponent<Light> ().intensity = Random.Range (0.25f, 0.75f);
	}
	public void ActivateDoor()
	{
		if (ObjectToActivate.name == _leftDoor)
			LeftDoor ();
		else if (ObjectToActivate.name == _rightDoor)
			RightDoor ();
	}
	void LeftDoor()
	{
		Vector3 temp = new Vector3 (0, 2.71f, 0);
		if (leftOpened == true) 
		{
			leftOpened = false;
			ObjectToActivate.transform.localPosition -= temp;
		}else
		{
			leftOpened = true;
			ObjectToActivate.transform.localPosition += temp;
		}
	}
	void RightDoor()
	{
		Vector3 temp = new Vector3 (0, 2.71f, 0);
		if (rightOpened == true) 
		{
			rightOpened = false;
			ObjectToActivate.transform.localPosition -= temp;
		}else
		{
			rightOpened = true;
			ObjectToActivate.transform.localPosition += temp;
		}
	}
	/*
		100f -= ( 0.1f * ObjectsPowered );
		
	 */
}
