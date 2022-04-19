using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    [SerializeField]
    private int lives = 5;

    [SerializeField]
    private int score = 0;
    public void increaseScore(int points)
    {
        score += points;
    }

    public void loseLives(int damage)
    {
        lives -= damage;
    }
}
