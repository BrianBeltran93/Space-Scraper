using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    private string _targetTag;
    public UnityEvent<GameObject> onEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == _targetTag)
        {
            onEnterEvent.Invoke(other.gameObject);
        }
    }
}
