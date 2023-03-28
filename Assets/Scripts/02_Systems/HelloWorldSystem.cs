using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class HelloWorldSystem : IInitializeSystem
{
    public void Initialize()
    {
        Debug.Log("Hello World!");
    }
}
