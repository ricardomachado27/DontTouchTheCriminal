using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public static float survivedTime;
    void Start()
    {
        survivedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        survivedTime += Time.deltaTime;
    }
}
