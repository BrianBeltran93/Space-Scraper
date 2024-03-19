using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private string _boolName = "Open";
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleDoorOpen());
    }

    private void ToggleDoorOpen()
    {
        bool isOpen = animator.GetBool(_boolName);
        animator.SetBool(_boolName, !isOpen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
