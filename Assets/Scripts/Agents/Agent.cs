using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Transform _playerTransform;
    private NavMeshAgent agent;
    [SerializeField]
    private GameManager gM;
    private EventDispatcher eventDispatcher;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = _playerTransform.position;
    }
}
