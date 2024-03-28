using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Realms;
using UnityEngine.Rendering;

public class RealmController : MonoBehaviour
{
    public static RealmController Instance;

    private Realm _realm;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
        if (_realm == null)
        {
            _realm = Realm.GetInstance();
        }
    }

    private void OnDisable()
    {
        if (_realm != null)
        {
            _realm.Dispose();
        }
    }

    private GameDataModel GetOrCreateGameData()
    {
        GameDataModel gameDataModel = _realm.Find<GameDataModel>("brian");
        if (gameDataModel == null)
        {
            _realm.Write(() =>
            {
                gameDataModel = _realm.Add(new GameDataModel()
                {
                    Id = "brian",
                    Score = 0,
                    X = 0,
                    Y = 0,
                    Z = 0
                });
            });
        }

        return gameDataModel;
    }

    public int GetScore()
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        return gameDataModel.Score;
    }
    
    public Vector3 GetPosition()
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        return new Vector3(gameDataModel.X, gameDataModel.Y, gameDataModel.Z);
    }
    
    public void IncreaseScore(int value)
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        _realm.Write(() =>
        {
            gameDataModel.Score += value;
        });
    }
    
    public void SetPosition(Vector3 position)
    {
        GameDataModel gameDataModel = GetOrCreateGameData();
        _realm.Write(() =>
        {
            gameDataModel.X = position.x;
            gameDataModel.Y = position.y;
            gameDataModel.Z = position.z;
        });
    }
}
