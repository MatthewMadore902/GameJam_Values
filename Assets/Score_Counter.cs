using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_Counter : MonoBehaviour
{
    public TextMeshProUGUI CountText;
    private float Count;
    private float startTime;
    // Start is called before the first frame update

    // attatch the script to the main camera and put the canvas text where it says Count Text

    //count sets to 0 on start of the game and SetCountText updates it as it goes along
    void Start()
    {
       // GUI.skin.box.fontSize = 10;
        SetCountText();
        Count = 0;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //change Input to what we decide the enemys will be named for when we kill them
        if (Input.GetKeyDown(KeyCode.C))
        {
            Count = Count + 10;
        }
        SetCountText();
    }

	void OnGUI()
	{
		
	}

	//this sets the score and displays it on screen with the canvas and a text 
	// you can also change the color of the text through <color=blahblahblah>
	void SetCountText()
    {
        CountText.text = "<color=#c0c0c0ff><size=25>Score:</size></color> " + Count.ToString("F0");
    }

	void FixedUpdate()
	{
        //set the int to however fast you want the score to go up
        //count = System.Math
        Count = Count + 100 * Time.deltaTime;
	}
}
