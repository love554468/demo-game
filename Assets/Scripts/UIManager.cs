using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameoverPanel;
    public Text Score_text;
    public void UpdateScore(string txt) 
    {
        if (Score_text)
        {
            Score_text.text = txt;
        }
    }
    public void ShowGameOverPanel(bool isShow)
    {
        if (gameoverPanel)
        {
            gameoverPanel.SetActive(isShow);
        }
    }
}
