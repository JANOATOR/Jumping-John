using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;

    public int numberOfPlatforms = 200; // Her laver vi en int variable som viser de numre af platforms vi skal bruge til at spawne.
    public float levelWidth = 3f; // Her laver vi en vaiarble som viser vi vores platforms bredte
    public float minY = 1.8f; // Her laver vi en variable som skal være vores min. Y afstand til platformene i det her tilfælde er det 1.8 som minimums afstand til platformene i Y-aksen.
    public float maxY = 2f; // Og den her variable viser hvordan maxY afstanden skal være til de andre platforme, i Y-aksen.
   
    
    void Start() {

        Vector3 spawnPosition = new Vector3(); // Her fortæller vores Vector3 at den skal 


        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
 
    
    void Update()
    {
        
    }
}
