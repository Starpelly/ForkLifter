using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProfiler : MonoBehaviour
{
    public float score = 0;
    public int totalHits = 0;

    public bool perfect = false; 

    public static GameProfiler instance { get; set; }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        perfect = true;
    }

    public void IncreaseScore()
    {
        totalHits++;
        score = GetPercent(totalHits, GameManager.instance.allPlayerActions.Count);
    }

    public float GetPercent(float value, float totalValue)
    {
        return (value / totalValue) * 100;
    }
}
