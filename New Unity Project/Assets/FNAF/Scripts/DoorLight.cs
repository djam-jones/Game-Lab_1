using UnityEngine;
using System.Collections;

public class DoorLight : MonoBehaviour {

	public GameObject ObjectToActivate;

	public bool leftClosed;
	public bool rightClosed;

	private string _leftDoor = "LeftDoor";
	private string _rightDoor = "RightDoor";

	private Vector3 _temp;
	private Power _power;

	void Start()
	{
		_power = GameObject.FindGameObjectWithTag (Tags.GameController).GetComponent<Power> ();
		if (ObjectToActivate.tag == Tags.Doors) 
		{
			RightDoor ();
			LeftDoor ();
		}
		_temp = new Vector3 (0, 2.71f, 0);
	}
	/*
	void OnMouseDown()
	{
		if (ObjectToActivate.tag == Tags.Doors)
			ActivateDoor ();
		else if (ObjectToActivate.tag == Tags.Lights)
			_power.powerUsage += 1;
	}
	void OnMouseDrag()
	{
		if (ObjectToActivate.tag == Tags.Lights)
			ActivateLight ();
	}
	void OnMouseUp()
	{
		if (ObjectToActivate.tag == Tags.Lights)
		{
			ObjectToActivate.GetComponent<Light> ().intensity = 0;
			_power.powerUsage -= 1;
		}
	}*/

	void OnCollisionEnter (Collision other)
	{	
		if (other.gameObject.tag == Tags.Hands) 
		{
			if (ObjectToActivate.tag == Tags.Doors)
				ActivateDoor ();
			else if (ObjectToActivate.tag == Tags.Lights)
				_power.powerUsage += 1;
		}
	}
	void OnCollisionStay (Collision other)
	{
		if (other.gameObject.tag == Tags.Hands)
		{
			if (ObjectToActivate.tag == Tags.Lights)
				ActivateLight ();
		}
	}
	void OnCollisionExit (Collision other)
	{
		if (other.gameObject.tag == Tags.Hands)
		{
			if (ObjectToActivate.tag == Tags.Lights)
			{
				ObjectToActivate.GetComponent<Light> ().intensity = 0;
				_power.powerUsage -= 1;
			}
		}
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
		if (leftClosed == true) 
		{
			leftClosed = false;
			_power.powerUsage += 1f;
			ObjectToActivate.transform.localPosition -= _temp;
		}else
		{
			leftClosed = true;
			_power.powerUsage -= 1f;
			ObjectToActivate.transform.localPosition += _temp;
		}
	}
	void RightDoor()
	{
		if (rightClosed == true) 
		{
			rightClosed = false;
			_power.powerUsage += 1f;
			ObjectToActivate.transform.localPosition -= _temp;
		}else
		{
			rightClosed = true;
			_power.powerUsage -= 1f;
			ObjectToActivate.transform.localPosition += _temp;
		}
	}
	/*
		100f -= ( 0.1f * ObjectsPowered );
		
	 */
}
