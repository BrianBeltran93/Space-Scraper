using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerZone : MonoBehaviour
{
    public UnityEvent<GameObject> onEnterEvent;
    
    [SerializeField]
    private string _targetTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_targetTag))
        {
            onEnterEvent.Invoke(other.gameObject);
        }
    }
}
