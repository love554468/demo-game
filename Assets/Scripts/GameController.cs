using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;

    int m_score;
    public float spawnTime; // khoảng thời gian tao ra qua bong tiep theo
    float m_spawnTime; // luu tru lai gia tri spawn time

    bool m_isGameOver;

    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UIManager>();
        m_ui.UpdateScore("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(m_isGameOver)
        {
            m_ui.ShowGameOverPanel(true);
            return;
        }
        if(m_spawnTime < 0)
        {
            // Debug.Log("chay vo trong");
            SpawnBall();
            m_spawnTime = spawnTime;
        }
        // Debug.Log(m_spawnTime);
    }

    // public void Replay()
    // {
    //     // m_score = 0;
    //     // m_ui.UpdateScore("Score: "+m_score);
    //     // m_isGameOver = false;
    //     // m_ui.ShowGameOverPanel(false);
    //     Debug.Log("hiiiiiiiiii");
    // }
    public void Replay()
    {
        m_score = 0;
        m_isGameOver = false;
        m_ui.UpdateScore("Score: "+m_score);
        m_ui.ShowGameOverPanel(false);
    }

    public void SpawnBall()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-7,7),4);
        if(ball)
        {
           Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        m_score = value;
    }

    public int GetScore()
    {
         return m_score;
    }

    public void IncrementScore()
    {
        m_score++;
        m_ui.UpdateScore("Score: "+m_score);
    }

    public bool IsGameOver()
    {
        return m_isGameOver;
    }

    public void SetGameOverState(bool States)
    {
        m_isGameOver = States;
    }
}
