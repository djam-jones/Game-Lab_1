using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
    private int _randomNumber;
    private float _interval = 5f;
    private Collider _buttonCol;

    void Start()
    {
        _buttonCol = GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision Other)
    {
        if (Other.gameObject.tag == Tags.handTag)
        {
            StartCoroutine(ButtonInterval());

            _randomNumber = Random.Range(1, 4);
            RandomEvent(_randomNumber);

            
        }
    }

    void RandomEvent(int index)
    {
        switch (index)
        {
            case 1:         
                Events.Instance.PlantEvent();
                break;

            case 2:
                Events.Instance.CrocoEvent();
                break;

            case 3:
				Events.Instance.VoiceEvent();
                break;
        }
    }
    private IEnumerator ButtonInterval()
    {
        _buttonCol.enabled = false;
        yield return new WaitForSeconds(_interval);
        _buttonCol.enabled = true;

        yield break;
    }
}