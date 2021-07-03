using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerX : MonoBehaviour
{
    private GameManagerX gameManagerX;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManagerX.isGameActive)
        {
            if (gameManagerX.timeRemaining > 0)
            {
                gameManagerX.timeRemaining -= Time.deltaTime;
            }
            else
            {
                gameManagerX.GameOver();
            }
            gameManagerX.timerText.text = "Time: " + Mathf.Round(gameManagerX.timeRemaining);
        }
        
    }
}
