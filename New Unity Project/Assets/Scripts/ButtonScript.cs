using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
    private int _randomNumber;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == Tags.handTag)
        {
            _randomNumber = Random.Range(1, 3);
            RandomEvent(_randomNumber);
            GameObject.FindGameObjectWithTag(Tags.plantTag).transform.position = new Vector3(-2, 0, 8.5f);
        }
    }

    void RandomEvent(int index)
    {
        switch (index)
        {
            case 1:
                Debug.Log("1");
                break;

            case 2:
                Debug.Log("2");
                break;

            case 3:
                Debug.Log("3");
                break;
        }
    }
}