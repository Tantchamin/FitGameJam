using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternPool : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddObjectToPattern(List<List<GameObject>> ListOfListGameOBJ,List<GameObject> ListGameOBJ)
    {
        ListOfListGameOBJ.Add(ListGameOBJ);
    }
    
}
