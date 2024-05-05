using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class StartGameButton : MonoBehaviour
{
    [SerializeField] private GameObject rightRaycast;
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text buttonCounter;
    [SerializeField] private GameObject menu;
    [SerializeField] private XROrigin xrOrigin;
    [SerializeField] private ActionBasedController rightController;
    
    public void StartGame()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;
        
        playerName.SetText(PlayerInfo.name);
        buttonCounter.SetText($"Times button pressed: {PlayerInfo.timesButtonPressed}");
        menu.SetActive(false);
        xrOrigin.GetComponent<DynamicMoveProvider>().enabled = true;
        xrOrigin.GetComponent<ActionBasedSnapTurnProvider>().enabled = true;
        rightRaycast.SetActive(false);
        gameObject.SetActive(false);
    }
    
}
