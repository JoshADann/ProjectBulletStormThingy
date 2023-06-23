using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamageManager
{
    private Transform _playerTransform;
    private float _damageRadius;
    private int _maxColliders;
    private Collider[] _hitColliders;

    public DamageManager(float damageRadius, int maxColliders, Transform playerTransform) 
    {
        _damageRadius = damageRadius;
        _hitColliders = new Collider[_maxColliders];
        _playerTransform = playerTransform;
    }

    public void CalculateDamage() 
    {


    }
}
