using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using GenericGameBackend.DataAccess;
using GenericGameBackend.Models;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    private List<SaveFileModel> _saveFilesList;

    private async void OnEnable()
    {
        var db = new SaveFileAccess();
        _saveFilesList = await db.GetAllSaveFiles();

        /*foreach (var doc in _saveFilesList)
        {
            Debug.Log(doc.Id);
            Debug.Log(doc.Name);
            Debug.Log(doc.TimesButtonPressed);
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
