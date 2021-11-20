using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Counter : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    private float count;
    private float startTime;
    // Start is called before the first frame update

    // attatch the script to the main camera and put the canvas text where it says Count Text

    //count sets to 0 on start of the game and SetCountText updates it as it goes along
    void Start()
    {
        SetCountText();
        count = 0;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //change Input to what we decide the enemys will be named for when we kill them
        if (Input.GetKeyDown(KeyCode.C))
        {
            count = count + 100000;
        }
        SetCountText();
    }

    //this sets the score and displays it on screen with the canvas and a text 
    void SetCountText()
    {
        CountText.text = "Score: " + count.ToString();
    }

	void FixedUpdate()
	{
        //count = System.Math
        count = count + 1 * Time.deltaTime;
	}
}
