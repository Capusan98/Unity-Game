
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;

    public GameObject ObstaclePrefab;
    public GameObject Obstacle1Prefab;
    public GameObject Obstacle2Prefab;
    public GameObject Obstacle3Prefab;

    public GameObject CoinPrefab;

    public float timeToSpawn = 2f;

    public float timeBetweebWaves =1.5f;

    public int Difficulty=4;

    public float GameTimeAtStart;
    public float CurrentGameTime;
    int[] NrOfObstacles = new int[5];
    void Start()
    {
       
        GameTimeAtStart = Time.time;
    }
    void Update()
    {
        CurrentGameTime = Time.time - GameTimeAtStart;
        
            if (CurrentGameTime > 40)
                Difficulty = 1;
            else if (CurrentGameTime > 15)
                Difficulty = 2;
            else if (CurrentGameTime > 5)
                Difficulty = 3;
          
       
        if (Time.time>=timeToSpawn)
            {
                SpawnBlocks();
                timeToSpawn = Time.time + timeBetweebWaves;
            }
            
     }
   
        // Update is called once per frame
        void SpawnBlocks()
        {
       
        int i,j,ok;
            for(i=0;i< SpawnPoints.Length;i++)
            {
            NrOfObstacles[i] = Random.Range(0, SpawnPoints.Length);
            }
            
           
        int randomCoinIndex = Random.Range(0, 5);


            for (i = 0; i < SpawnPoints.Length; i++)
            {
            ok = 0;
                for(j=0;j<Difficulty;j++)
                if(i==NrOfObstacles[j])
                {
                    if (i == randomCoinIndex)
                        Instantiate(CoinPrefab, SpawnPoints[i].position, Quaternion.identity);
                    ok = 1;
                    break;
                   
                }
            
                if(ok==0)
                {
                if(Difficulty==4)
                    Instantiate(ObstaclePrefab, SpawnPoints[i].position, Quaternion.identity);
                else if (Difficulty == 3)
                    Instantiate(Obstacle1Prefab, SpawnPoints[i].position, Quaternion.identity);
                else if (Difficulty == 2)
                    Instantiate(Obstacle2Prefab, SpawnPoints[i].position, Quaternion.identity);
                else if (Difficulty == 1)
                    Instantiate(Obstacle3Prefab, SpawnPoints[i].position, Quaternion.identity);
                 }
                
               
                
            }
            
        }
    }
