using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class LoadGame : MonoBehaviour
{
    [SerializeField] private TMP_Text[] buttons;
    [SerializeField] private ActionBasedController rightController;
    [SerializeField] private GameObject saveFilePanel;
    
    private List<SaveFileModel> _saveFilesList;
    

    private async void OnEnable()
    {
        var db = new SaveFileAccess();
        _saveFilesList = await db.GetAllSaveFiles();


        int i = 0;
        foreach (var doc in _saveFilesList)
        {
            /*Debug.Log(doc.Id);
            Debug.Log(doc.Name);
            Debug.Log(doc.TimesButtonPressed);*/
            
            buttons[i].transform.parent.gameObject.SetActive(true);
            buttons[i].SetText($"{doc.Name}<br>" +
                               $"Button Presses: {doc.TimesButtonPressed}");
            i++;
        }
    }

    public void FileOne()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;
        
        PlayerInfo.id = _saveFilesList[0].Id;
        PlayerInfo.name = _saveFilesList[0].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[0].TimesButtonPressed;
        SaveFilePanelEnable();
    }
    
    public void FileTwo()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;

        PlayerInfo.id = _saveFilesList[1].Id;
        PlayerInfo.name = _saveFilesList[1].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[1].TimesButtonPressed;
        SaveFilePanelEnable();
    }
    
    public void FileThree()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;

        PlayerInfo.id = _saveFilesList[2].Id;
        PlayerInfo.name = _saveFilesList[2].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[2].TimesButtonPressed;
        SaveFilePanelEnable();
    }
    
    public void FileFour()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;

        PlayerInfo.id = _saveFilesList[3].Id;
        PlayerInfo.name = _saveFilesList[3].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[3].TimesButtonPressed;
        SaveFilePanelEnable();
    }
    
    public void FileFive()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;

        PlayerInfo.id = _saveFilesList[4].Id;
        PlayerInfo.name = _saveFilesList[4].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[4].TimesButtonPressed;
        SaveFilePanelEnable();
    }
    
    public void FileSix()
    {
        if (!rightController.currentControllerState.activateInteractionState.active) return;

        PlayerInfo.id = _saveFilesList[5].Id;
        PlayerInfo.name = _saveFilesList[5].Name;
        PlayerInfo.timesButtonPressed = _saveFilesList[5].TimesButtonPressed;
        SaveFilePanelEnable();
    }

    private void SaveFilePanelEnable()
    {
        foreach (var button in buttons)
        {
            button.transform.parent.gameObject.SetActive(false);
        }
        saveFilePanel.SetActive(true);
        gameObject.SetActive(false);
    }
    
    
}
