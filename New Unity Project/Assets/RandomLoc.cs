using UnityEngine;
using System.Collections;

public class RandomLoc : MonoBehaviour {

	public GameObject[] locs;

	public void GoRandomPositioneh()
	{
		this.transform.position = locs [Random.Range (0, locs.Length)].transform.position;
	}
}
