using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Exercise5Listener : MonoBehaviour
{
    public List<Exercise4Sender> ballsHit;
    public int points = 0;
    public TMP_Text pointsText;
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
        pointsText.text = $"Points : {points}";
    }
}
