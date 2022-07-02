using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPooling : MonoBehaviour
{
    public List<GameObject> poolObjectList = new List<GameObject>();
    public PoolObject poolObject = new PoolObject();

    private GameObject objectInTime;
    void Start()
    {
        for (int i = 0;i<poolObjectList.Count;i++)
        {
            poolObject.AddGameObjectTypeToPool(poolObjectList[i]);
        }
        poolObject.CreateGameObjectFromPool();
    }


    void FixedUpdate()
    {
        bool isSpawned = poolObject.SpawnStatus();
        if (isSpawned == false)
        {
            StartCoroutine(SpawnFrequency());
        }
        else if (isSpawned == true)
        {
           // StartCoroutine(Stop());
        }
    }
    
    IEnumerator SpawnFrequency()
    {
        RandomObjectSpawner();
        yield return new WaitForSeconds(3f);
        StartCoroutine(Stop());
    }
    IEnumerator Stop()
    {
        yield return new WaitForSeconds(5f);
        objectInTime.transform.position = gameObject.transform.position;
        poolObject.DisableObjectInPool(objectInTime);
        
       
    }
    public void RandomObjectSpawner()
    {
        int randomNumber = Random.Range(0,poolObjectList.Count);
        objectInTime = poolObject.EnableObjectInPool(randomNumber);
    }
}
