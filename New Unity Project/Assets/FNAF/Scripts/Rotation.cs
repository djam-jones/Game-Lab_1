using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.Rotate(Vector3.right * Time.deltaTime * 10);
        this.transform.Rotate(Vector3.up * Time.deltaTime * 2);
    }
}
