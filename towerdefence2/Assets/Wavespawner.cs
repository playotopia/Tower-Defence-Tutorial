
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Wavespawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timebetweenwaves = 5f;

    public Transform spawnPoint;

    private float countdown = 2f;


    public Text waveCountdownText;
    private int waveIndex = 0;
    void Update() {
        if(countdown<=0f)
        {
            StartCoroutine(SpawnWave());
                countdown = timebetweenwaves;

        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }
  IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.3f);
        }
       
    }

    void SpawnEnemy()
    {

        Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation);


    }

}
