using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public RowUI rowui;
    public ScoreManager scoreManager;
    public float scoreDisplay;

    void Start()
    {
        scoreManager.AddScore(new Score("SUB", scoreDisplay));

        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowui, transform).GetComponent<RowUI>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
	void Update()
	{
        Debug.Log(scoreDisplay); 
	}
}
