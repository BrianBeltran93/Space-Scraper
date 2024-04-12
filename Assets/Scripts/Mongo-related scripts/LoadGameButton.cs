using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class LoadGameButton : MonoBehaviour
{
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private GameObject loadGamePanel;
    [SerializeField] private GameObject newGamePanel;

    public void ActivateLoadGameMenu()
    {
        if (rightController.currentControllerState.activateInteractionState.active)
        {
            loadGamePanel.SetActive(true);
            newGamePanel.SetActive(false);
        }
    }
}
