using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4Listener : MonoBehaviour
{
    public List<Exercise4Sender> ballsHit;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var ball in ballsHit) {
            ball.OnHit += AddPoints;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void AddPoints(int pointsToAdd) {
        points += pointsToAdd;
        Debug.Log($"Points: {points}");
    }
}
