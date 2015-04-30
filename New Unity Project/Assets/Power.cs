using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Power : MonoBehaviour {

	public Text powerText;
	private float _maxPower;
	public float power;

	public float powerUsage;
	
	void Start () 
	{
		powerUsage = 1f;
		_maxPower = 25000f;
		power = 25000f;
	}
	void Update () 
	{
		DecreasePowerLevel (powerUsage);
	}
	void DecreasePowerLevel (float powerReq)
	{
		power = power - powerReq;
		powerText.text = "Power Left : " + ((power / _maxPower) * 100).ToString("F0") + " % \n" + powerUsage + " == " + powerReq;
	}
}
