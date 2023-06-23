using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDispatcher
{
    public event Action OnEnemyDamaged;
    
    public void TriggerEnemyDamaged()
    {
        OnEnemyDamaged?.Invoke();
    }
}
