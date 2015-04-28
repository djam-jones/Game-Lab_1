using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CamStatic : MonoBehaviour {

	public Image staticImg;
	public Sprite[] cookies;
	public bool laptopOpen;

	void Start()
	{
		//staticImg.sprite.
	}
	void Update () 
	{
		Color invisColor = new Color (1, 1, 1, 0);
		Color visColor = new Color (1, 1, 1, 1);
		if (laptopOpen == true)
		{
			staticImg.color = visColor;
			staticImg.sprite = cookies [Random.Range (0, cookies.Length)];
		}
		else
			staticImg.color = invisColor;
	}
}
