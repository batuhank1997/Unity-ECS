using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitTriggerEntityBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + " : " + other.name);
        var entity = Contexts.sharedInstance.game.CreateEntity();
        entity.AddCollision(gameObject, other.gameObject);
    }
}
