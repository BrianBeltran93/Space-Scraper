using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().onEnterEvent.AddListener(InsideTrash);
    }

    private void InsideTrash(GameObject go)
    {
        go.SetActive(false);
    }
}