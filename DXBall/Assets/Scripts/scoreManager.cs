using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement; //import scene management library


public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText; 
    int score = 0;

    public GameObject ball;
    public GameObject paddle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


public void addScore(int input){
    if (input == 1){
        score = score +input;
        scoreText.text = "Score: " + score.ToString();
        if (score == 21){
            winText.text = "You Win!";
            ball.SetActive(false); 
            paddle.SetActive(false);
            
            SceneManager.LoadScene("Level2"); //load level 2
        }

    }else if ( input ==0){
        winText.text = "Game Over!";
    }
}
} 