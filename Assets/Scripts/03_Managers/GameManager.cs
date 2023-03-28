using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameConfig _gameConfigSO;
    
    private Contexts _contexts;
    private GameSystems _gameSystems;
    
    void Start()
    {
        _contexts = Contexts.sharedInstance;
        
        if (!_contexts.game.hasGameConfig)
            _contexts.game.SetGameConfig(_gameConfigSO);
        
        _gameSystems = new GameSystems(_contexts);
        _gameSystems.Initialize();
    }

    void Update()
    {
        _gameSystems.Execute();
    }
}
