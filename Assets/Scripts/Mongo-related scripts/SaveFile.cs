using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveFile : MonoBehaviour
{
    [SerializeField] private TMP_Text saveFileInfo;

    private void OnEnable()
    {
        saveFileInfo.SetText($"{PlayerInfo.name}<br>" +
                             $"Button Presses: {PlayerInfo.timesButtonPressed}");
    }
}
