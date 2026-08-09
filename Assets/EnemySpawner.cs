using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyGameObject;
    public float spawnInterval = 1f;

    public Transform SpawnTranform;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }


    private IEnumerator SpawnObjects()
    {

        while (true)
        {
            Vector3 pos = SpawnTranform.position;
            pos.y = Random.Range(-5f, 5f);

            Instantiate(enemyGameObject, pos, SpawnTranform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
