using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeNavImage : MonoBehaviour {

	public Texture[] navImages;
	private Renderer _navMat;

	private int _buttonIndex;
	private int _buttonId;
	private int[] _buttonOrder;
	public List<GameObject> steeringButtons = new List<GameObject>();

	void Awake()
	{
		_navMat = GetComponent<Renderer>();
		_navMat.material.mainTexture = navImages[0];

		_buttonOrder = new int[]
		{
			0, 1, 2, 3, 4, 5
		};
	}

	void Start()
	{
		GiveButtonIndex();
	}

	//TODO: Create Buttons to click in an order to get away from the Object you're drifting towards.

	void GiveButtonIndex()
	{
		for(int i = 1; i < _buttonIndex; i++)
		{
			foreach(GameObject button in steeringButtons)
			{
				_buttonId++;
				button.tag = Tags.buttonTag + _buttonId.ToString();
			}
		}
	}
}