using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AddScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => AddButtonPress());
    }

    private void AddButtonPress()
    {
        RealmController.Instance.IncreaseScore(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
