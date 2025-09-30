using UnityEngine;
using UnityEngine.SceneManagement; // optional if switching scenes

public class StartButonScript : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start button clicked!");
        // Example: load a scene called "GameScene"
        SceneManager.LoadScene("Level1");
    }
}
