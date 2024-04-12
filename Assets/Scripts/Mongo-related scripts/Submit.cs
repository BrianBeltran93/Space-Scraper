using System;
using System.Collections;
using System.Collections.Generic;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class Submit : MonoBehaviour
{
    [SerializeField] private Button submitBtn;
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private LineRenderer rend;
    [SerializeField] private new TMP_InputField name;
    [SerializeField] private GameObject xrOrigin;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject keyboard;
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text buttonCounter;

    public void SubmitData()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;
       
        var data = new SaveFileModel()
        {
            Name = name.text,
            TimesButtonPressed = 0
        };
        var db = new SaveFileAccess();
        db.CreateSaveFile(data);
        PlayerInfo.name = data.Name;
        PlayerInfo.timesButtonPressed = data.TimesButtonPressed;
        PlayerInfo.id = data.Id;
        StartGame();
    }
    
    private void StartGame()
    {
        playerName.SetText(PlayerInfo.name);
        buttonCounter.SetText($"Times button pressed: {PlayerInfo.timesButtonPressed}");
        menu.SetActive(false);
        keyboard.SetActive(false);
        xrOrigin.GetComponent<DynamicMoveProvider>().enabled = true;
        xrOrigin.GetComponent<ActionBasedSnapTurnProvider>().enabled = true;
        gameObject.SetActive(false);
    }
}
