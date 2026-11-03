using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DeathMenu : MonoBehaviour
{
    public TMP_Text timeText;
    public string gameSceneName = "GameScene";
    
    void Start()
    {
        timeText.text = "You were untainted for " + GameTimer.survivedTime.ToString("F1") + " seconds";
    }

    public void Retry()
    {
        SceneManager.LoadScene(gameSceneName);
    }

  
    void Update()
    {
        
    }
}
