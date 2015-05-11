using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour {

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
        Debug.Log("plant");
        GameObject.FindGameObjectWithTag(Tags.plantTag).transform.position = new Vector3(-2, 0, 8.5f);
    }

	public void VoiceEvent()
	{
        Debug.Log("voice");
		//Play Audio
	}
}
