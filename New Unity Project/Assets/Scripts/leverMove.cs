using UnityEngine;
using System.Collections;

public class leverMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.rotation.x <= 70 && transform.rotation.x >= -90) 
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 100);
        }	
    }
}
