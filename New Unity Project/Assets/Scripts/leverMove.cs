using UnityEngine;
using System.Collections;

public class leverMove : MonoBehaviour {
    private Quaternion _rot;
    private bool _switched = false;

    void Start()
    {
        _rot = transform.rotation;
    }

	void Update () {

        Debug.Log(transform.rotation.x);
        if (Input.GetKeyDown(KeyCode.W))
            _switched = true;
        if (_switched)
            Switch();
    }

    void Switch()
    {
        if (this.transform.rotation.x <= 0.5f)
        {
            this.transform.Rotate(Vector3.right * Time.deltaTime * 10);
        }
        else if (this.transform.rotation.x >= 0.5f)
        {
            this.transform.rotation = _rot;
            _switched = false;
        }
    }
}