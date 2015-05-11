using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CamStatic : MonoBehaviour {

	public Image staticImg;
	public Sprite[] cookies;
	public bool laptopOpen;
	private Color _invisColor = new Color (1, 1, 1, 0);
	private Color _visColor = new Color (1, 1, 1, 1);

	void Update () 
	{
		if (laptopOpen == true)
		{
			staticImg.color = _visColor;
			staticImg.sprite = cookies [Random.Range (0, cookies.Length)];
		}
		else
			staticImg.color = _invisColor;
	}
}
