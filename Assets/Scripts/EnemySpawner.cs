using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Shredder;
    [SerializeField]
    private GameObject DoubleShot;
    [SerializeField]
    private GameObject DoubleShotFar;
    [SerializeField]
    private GameObject DoubleShotFarther;

    [SerializeField]
    private float shredderInterval = 10f;
    [SerializeField]
    private float doubleInterval = 5f;
    [SerializeField]
    private float DoubleShotFarInterval;
    [SerializeField]
    private float DoubleShotFartherInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(shredderInterval, Shredder));
        StartCoroutine(spawnEnemy(doubleInterval, DoubleShot));
        StartCoroutine(spawnEnemy(DoubleShotFarInterval, DoubleShotFar));
        StartCoroutine(spawnEnemy(DoubleShotFartherInterval, DoubleShotFarther));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
