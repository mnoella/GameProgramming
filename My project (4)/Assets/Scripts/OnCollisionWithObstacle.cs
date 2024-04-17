using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnCollisionWithObstacle : MonoBehaviour
{

    public Button restartButton;
    public TextMeshProUGUI gameOver;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            restartButton.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(true);

            Time.timeScale = 0f;
            
        }

        else if (collision.gameObject.CompareTag("Coin"))
        {
            ScoreManager.scoreCount += 1;
            Destroy(collision.gameObject);
            UpdateScoreText();
        }

    }

    void RestartGame()
    {
        ScoreManager.scoreCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + ScoreManager.scoreCount.ToString();
    }
}
