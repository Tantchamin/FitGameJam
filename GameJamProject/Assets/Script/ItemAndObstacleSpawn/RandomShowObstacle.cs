using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomShowObstacle : MonoBehaviour
{
    public List<GameObject> obstacleList = new List<GameObject>();
    private int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, obstacleList.Count);
        obstacleList[randomNumber].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
