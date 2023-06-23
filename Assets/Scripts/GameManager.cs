using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerTransform;


    // damageManager
    public DamageManager damageManager;
    [SerializeField]
    private float _playerDamageRadius = 5f;
    [SerializeField]
    private int _maxColliders = 30;





    void Start()
    {
        damageManager = new DamageManager(_playerDamageRadius, _maxColliders, playerTransform);
    }

    void Update()
    {
        damageManager.CalculateDamage();
    }
}
