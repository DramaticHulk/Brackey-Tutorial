using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Score>().scoreText.text = ((int)(movement.transform.position.z / 10)).ToString() + "\nGame Over";
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
