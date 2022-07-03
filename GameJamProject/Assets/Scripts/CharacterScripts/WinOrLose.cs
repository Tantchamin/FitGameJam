using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinOrLose : MonoBehaviour
{
    private EnvironmentHitPlayer EnvironmentHitPlayer1;
    private EnvironmentHitPlayer EnvironmentHitPlayer2;
    public GameObject player1;
    public GameObject player2;
    public GameObject status1;
    public GameObject status2;
    // Start is called before the first frame update
    void Start()
    {
        EnvironmentHitPlayer1 = player1.GetComponent<EnvironmentHitPlayer>();
        EnvironmentHitPlayer2 = player2.GetComponent<EnvironmentHitPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lose(GameObject player)
    {
        if (player.tag == "Player1")
        {
            status1.GetComponent<Text>().text = "Lose";
            status2.GetComponent<Text>().text = "Win";
        }
        else if (player.tag == "Player2")
        {
            status2.GetComponent<Text>().text = "Lose";
            status1.GetComponent<Text>().text = "Win";
        }
        Time.timeScale = 0;
    }
    public void Win()
    {
        Time.timeScale = 0;
    }
}
