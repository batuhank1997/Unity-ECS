using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class GameManager : MonoBehaviour
{
    private TransformAccessArray transforms;

    private MovementJob movementJob;
    private JobHandle movementHandle;

    private void OnDisable()
    {
        movementHandle.Complete();
        transforms.Dispose();
    }

    private void Start()
    {
        
    }
}
