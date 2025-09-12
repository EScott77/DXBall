using UnityEngine;
using TMPro;


public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    int score = 0;

    public GameObject ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


public void addScore(int input){
    if (input == 1){
        score = score +input;
        scoreText.text = score.ToString()+ " Points";
        if (score == 21){
            winText.text = "You Win!";
           ball.SetActive(false); 
        }

    }else if ( input ==0){
        winText.text = "Game Over!";
    }
}
} 