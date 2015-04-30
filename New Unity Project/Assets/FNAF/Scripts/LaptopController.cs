using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LaptopController : MonoBehaviour {

	public GameObject openLapObj;
	public GameObject closeLapObj;
	public GameObject camInterface;
	
	private GameObject[] _cams;
	private GameObject _mainCam;
	//private float _timer = 1;
	//private float _switchTime;
	private int _lastCamOpenend;
	private CamStatic _camStatic;

	void Start()
	{
		_camStatic = GameObject.FindGameObjectWithTag (Tags.GameController).GetComponent<CamStatic> ();
		_mainCam = GameObject.FindGameObjectWithTag (Tags.MainCamera);
		_cams = GameObject.FindGameObjectsWithTag (Tags.Cameras);
		closeLapObj.SetActive (false);
		camInterface.SetActive (false);
		foreach (GameObject obj in _cams)
		{
			obj.SetActive(false);
		}
		_lastCamOpenend = 0;
	}
	public void OpenLaptop()
	{
		GameObject.Find ("Enemy").GetComponent<RandomLoc> ().GoRandomPositioneh ();
		_camStatic.laptopOpen = true;
		openLapObj.SetActive (false);
		closeLapObj.SetActive (true);
		camInterface.SetActive (true);		
		_mainCam.SetActive (false);
		ChangeCamera (_lastCamOpenend);
		_camStatic.laptopOpen = true;
	}
	public void CloseLaptop()
	{
		_camStatic.laptopOpen = false;
		openLapObj.SetActive (true);
		closeLapObj.SetActive (false);		
		camInterface.SetActive (false);
		_mainCam.SetActive (true);		
		_cams [_lastCamOpenend].SetActive (false);
	}
	public void ChangeCamera(int num)
	{
		foreach (GameObject obj in _cams)
		{
			obj.SetActive(false);
			_cams[num].SetActive(true);
			_lastCamOpenend = num;

		}
	}
}
