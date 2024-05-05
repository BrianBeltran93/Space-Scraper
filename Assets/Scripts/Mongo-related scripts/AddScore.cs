using System.Collections;
using System.Collections.Generic;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AddScore : MonoBehaviour
{
    [SerializeField] private TMP_Text playerScore;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => AddButtonPress());
    }

    private void AddButtonPress()
    {
        var data = new SaveFileModel()
        {
            Id = PlayerInfo.id,
            Name = PlayerInfo.name,
            TimesButtonPressed = PlayerInfo.timesButtonPressed
        };
        
        var db = new SaveFileAccess();
        db.UpdateSaveFile(data);
        PlayerInfo.timesButtonPressed++;
        playerScore.SetText($"Times button pressed: {PlayerInfo.timesButtonPressed.ToString()}" );
    }
}
