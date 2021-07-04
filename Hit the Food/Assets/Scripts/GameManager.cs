using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI livesText;
    public Button restartButton;
    public Scrollbar scrollbar;
    public GameObject titleScreen;
    public bool isGameActive;
    private int score;
    private int lives = 3;
    private float spawnRate = 1.0f;
    private AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "Lives: " + lives;

        backgroundMusic = GetComponent<AudioSource>();
        scrollbar.onValueChanged.AddListener((float val) => SetVolume(val));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        spawnRate = spawnRate / difficulty;
        StartCoroutine("SpawnTarget");
        UpdateScore(0);

        titleScreen.gameObject.SetActive(false);
    }
    public void AddLives(int number)
    {
        lives += number;
        livesText.text = "Lives: " + lives;
        if (lives < 1)
        {
            GameOver();
        }
    }

    void SetVolume(float val)
    {
        backgroundMusic.volume = val;
    }
}
