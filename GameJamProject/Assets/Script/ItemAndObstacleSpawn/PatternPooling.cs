using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPooling : MonoBehaviour
{
    public List<GameObject> poolObject1 = new List<GameObject>();
    public List<GameObject> poolObject2 = new List<GameObject>();
    public List<GameObject> poolObject3 = new List<GameObject>();
    private List<List<GameObject>> poolPattern = new List<List<GameObject>>();
    private PatternPool PatternPool = new PatternPool();

    void Start()
    {
        PatternPool.AddObjectToPattern(poolPattern,poolObject1);
        PatternPool.AddObjectToPattern(poolPattern,poolObject2);
        PatternPool.AddObjectToPattern(poolPattern,poolObject3);
    }


    void Update()
    {
        
    }
}
