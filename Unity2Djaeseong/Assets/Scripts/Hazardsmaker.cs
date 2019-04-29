using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazardsmaker : MonoBehaviour
{
    public GameObject[] hazards;
    public float startWait = 1;
    public float spawnWait = 0.75f;
    public float waveWait = 2;
    public Transform tr;
    int a = 1;
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(1);

        while (true)
        {
            for (int i = 0; i < 10; ++a)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = tr.position + new Vector3(Random.Range(-8,8),0,0);
                Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, 180, 0));
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
  
            }
            yield return new WaitForSeconds(waveWait);
      
        }
    }
}
