using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class LineRendererSettings : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private LineRenderer rend;
    [SerializeField] private Button newGameBtn;
    [SerializeField] private Button submitBtn;
    [SerializeField] private Button loadGameBtn;
    [SerializeField] private Button[] saveFileBtns;
    [SerializeField] private Button startGameBtn;
    [SerializeField] private Button deleteSaveFileBtn;
    
    private Vector3[] _points;
    

    private void Update()
    {
        AlignLineRenderer();
    }

    private void AlignLineRenderer()
    {
        
        rend.SetPosition(0, transform.position);
        Vector3 rayOrigin = transform.position;
        RaycastHit hit;

        if (Physics.Raycast(rayOrigin, transform.forward, out hit, 100f, layerMask))
        {
            rend.SetPosition(1, hit.point);
            rend.startColor = Color.red;
            rend.endColor = Color.red;

            if (hit.transform.name == "NewGameButton")
            {
                newGameBtn.onClick.Invoke();
            }
            else if (hit.transform.name == "SubmitButton")
            {
                submitBtn.onClick.Invoke();
            }
            else if (hit.transform.name == "LoadGameButton")
            {
                loadGameBtn.onClick.Invoke();
            }
            else if (hit.transform.name == "FileOne")
            {
                saveFileBtns[0].onClick.Invoke();
            }
            else if (hit.transform.name == "FileTwo")
            {
                saveFileBtns[1].onClick.Invoke();
            }
            else if (hit.transform.name == "FileThree")
            {
                saveFileBtns[2].onClick.Invoke();
            }
            else if (hit.transform.name == "FileFour")
            {
                saveFileBtns[3].onClick.Invoke();
            }
            else if (hit.transform.name == "FileFive")
            {
                saveFileBtns[4].onClick.Invoke();
            }
            else if (hit.transform.name == "FileSix")
            {
                saveFileBtns[5].onClick.Invoke();
            }
            else if (hit.transform.name == "StartGameButton")
            {
                startGameBtn.onClick.Invoke();
            }
            else if (hit.transform.name == "DeleteSaveButton")
            {
                deleteSaveFileBtn.onClick.Invoke();
            }
        }
        else
        {
            rend.SetPosition(1, rayOrigin + (transform.forward * 100f));
            rend.startColor = Color.green;
            rend.endColor = Color.green;
        }
        
        rend.material.color = rend.startColor;
    }
}
