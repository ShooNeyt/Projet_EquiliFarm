using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipManager : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public float timeBeforeTurnipGeneration = 1;
    public float currentTimeBeforeNextTurnip = 0;
    public GameObject turnip;
    public GameObject turnipParent;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeBeforeNextTurnip += Time.deltaTime;


        if (currentTimeBeforeNextTurnip >= timeBeforeTurnipGeneration)
        {
            GenerateTurnipFromSpawnPoints();
            currentTimeBeforeNextTurnip = 0;
        }

        void GenerateTurnipFromSpawnPoints()
        {
         GameObject newEnemy = Instantiate(turnip);

         int IndexChosenOne = Random.Range(0, spawnPoints.Count);
         Transform chosenOne = spawnPoints[IndexChosenOne];

         newEnemy.transform.position = chosenOne.position;
        }
    }
}
