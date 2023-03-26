using System;
using System.Collections;
using System.Collections.Generic;
using Systems;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private RootSystems _systems;
    
    void Start()
    {
        _systems = new RootSystems(Contexts.sharedInstance);
        
        _systems.Initialize();
    }

    private void Update()
    {
        _systems.Execute();
    }
}
