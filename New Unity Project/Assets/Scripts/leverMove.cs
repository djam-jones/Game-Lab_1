using UnityEngine;
using System.Collections;

public class leverMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.rotation.x >= 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime);
        }
	}
}
