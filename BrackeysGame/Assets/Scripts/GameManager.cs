using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public Transform player;
    public float restartDelay = 1.6f;
    public Score text;

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            string v = ((int)(player.position.z / 10)).ToString() + "\nGame Over";
            text.scoreText.text = v;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

