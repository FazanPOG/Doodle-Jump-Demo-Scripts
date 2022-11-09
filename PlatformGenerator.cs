using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _platformPrefabs;
    private int randomPrefabs;

    [SerializeField] private int _numberOfPlatforms;

    [SerializeField] private float _MinYPos = 1.5f;
    [SerializeField] private float _MaxYPos = 5f;

    [SerializeField] private float _MinXPos = -6f;
    [SerializeField] private float _MaxXPos = 6f;

    private void Start()
    {
        Vector3 spawnPos = new Vector3(0,0,-1);

        for (int i = 0; i < _numberOfPlatforms; i++) 
        {
            randomPrefabs = Random.RandomRange(0, _platformPrefabs.Length);
            spawnPos.x = Random.Range(_MinXPos, _MaxXPos);
            spawnPos.y += Random.Range(_MinYPos, _MaxYPos);
           

            Instantiate(_platformPrefabs[randomPrefabs], spawnPos, Quaternion.identity);
        }
    }
}
