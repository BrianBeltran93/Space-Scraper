using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _player;
    
    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "SCORE 0";
        _player.transform.position = RealmController.Instance.GetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Times button pressed: " + RealmController.Instance.GetScore().ToString();
        RealmController.Instance.SetPosition(_player.transform.position);
    }
}
