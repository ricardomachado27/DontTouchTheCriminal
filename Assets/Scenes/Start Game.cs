using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string gameSceneName = "GameScene";

    void Start()
    {
        Debug.Log("Start menu loaded");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
