using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MeteorPistol : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform shootSource;

    private bool _rayActive;
    
    private const float Distance = 10;


    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShoot());
        grabInteractable.deactivated.AddListener(x => StopShoot());
        
    }

    private void StartShoot()
    {
        particles.Play();
        _rayActive = true;
    }

    private void StopShoot()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        _rayActive = false;
    }

    private void Update()
    {
        if (_rayActive)
        {
            RaycastCheck();
        }
    }

    private void RaycastCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward,
            out hit, Distance, layerMask);

        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
