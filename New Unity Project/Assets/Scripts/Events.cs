using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour
{

    private static Events _instance;

    public static Events Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType(typeof(Events)) as Events;
            }

            return _instance;
        }
    }

    public void PlantEvent()
    {
        GameObject.FindGameObjectWithTag(Tags.plantTag).transform.position = new Vector3(-2, 0, 8.5f);
    }

    public void CrocoEvent()
    {
        GameObject.FindGameObjectWithTag(Tags.crocoTag).transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1, this.transform.position.z);
    }

    public void HeadFlipEvent()
    {
        //GameObject.FindGameObjectsWithTag(Tags.playerCameraTag).transform.rotation = new Vector3(this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z);
    }
}

