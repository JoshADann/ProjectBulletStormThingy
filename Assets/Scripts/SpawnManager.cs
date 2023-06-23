using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _spawnableAgents;
    private Vector3[] _spawnPointPositions;
    [SerializeField]
    private int _secondsBetweenSpawns = 5;
    [SerializeField]
    private Transform _playerTransform;

    void Start()
    {
        GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        _spawnPointPositions = new Vector3[spawnPoints.Length];

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            _spawnPointPositions[i] = spawnPoints[i].transform.position;
        }

        StartCoroutine(EnemySpawner());
    }

    void Update()
    {

    }

    private IEnumerator EnemySpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(_secondsBetweenSpawns);

            GameObject enemyToSpawn = _spawnableAgents[Random.Range(0, _spawnableAgents.Length - 1)];
            Vector3 spawnPos = _spawnPointPositions[Random.Range(0, _spawnPointPositions.Length - 1)];

            GameObject newEnemy = Instantiate(enemyToSpawn,spawnPos, Quaternion.identity);
            newEnemy.GetComponent<Agent>()._playerTransform = _playerTransform;
        }
    }

    private void SpawnEnemy()
    {
        GameObject enemyToSpawn = _spawnableAgents[Random.Range(0, _spawnableAgents.Length - 1)];
        Vector3 spawnPos = _spawnPointPositions[Random.Range(0, _spawnPointPositions.Length - 1)];

        GameObject newEnemy = Instantiate(enemyToSpawn, spawnPos, Quaternion.identity);
        newEnemy.GetComponent<Agent>()._playerTransform = _playerTransform;
    }
}
