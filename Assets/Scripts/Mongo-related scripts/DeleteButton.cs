using System.Collections;
using System.Collections.Generic;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DeleteButton : MonoBehaviour
{
    [SerializeField] private GameObject newGamePanel;
    [SerializeField] private GameObject saveFilePanel;
    [SerializeField] private ActionBasedController rightController;
    
    public void DeleteSaveFile()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;
        
        var data = new SaveFileModel()
        {
            Id = PlayerInfo.id,
            Name = PlayerInfo.name,
            TimesButtonPressed = PlayerInfo.timesButtonPressed
        };
        
        var db = new SaveFileAccess();

        db.DeleteSaveFile(data);
        
        newGamePanel.SetActive(true);
        saveFilePanel.SetActive(false);
    }
}
