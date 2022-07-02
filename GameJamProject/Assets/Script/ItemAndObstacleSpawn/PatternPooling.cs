using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPooling : MonoBehaviour
{
    public List<GameObject> poolObjectList = new List<GameObject>();
    public PoolObject poolObject = new PoolObject();

    void Start()
    {
        for (int i = 0;i<poolObjectList.Count;i++)
        {
            poolObject.AddGameObjectTypeToPool(poolObjectList[i]);
        }
        poolObject.CreateGameObjectFromPool();
    }


    void Update()
    {
   
    }
    public void RandomObjectSpawner()
    {
        
    }
}
