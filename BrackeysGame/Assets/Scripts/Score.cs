using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameManager gameOver;
    private string finalScore;

    // Update is called once per frame
    public void Update()
    {
        if (gameOver.gameOver == true)
        {
            scoreText.text = finalScore + "\n Game Over";
        }
        else
        {
            scoreText.text = ((int)(player.position.z / 10)).ToString();
            finalScore = scoreText.text;
        }
    }

   
    

}
