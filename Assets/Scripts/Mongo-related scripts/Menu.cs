using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using TMPro;


public class Menu : MonoBehaviour
{
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private GameObject enterNamePanel;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private GameObject newGamePanel;
    [SerializeField] private GameObject keyboard;

    public void ActivateNameMenu()
    {
        if (rightController.currentControllerState.activateInteractionState.active)
        {
            enterNamePanel.SetActive(true);
            inputField.ActivateInputField();
            keyboard.gameObject.SetActive(true);
            newGamePanel.SetActive(false);
        }
    }
}
