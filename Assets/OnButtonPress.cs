using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPress : MonoBehaviour
{
    public GameObject leaderBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            leaderBoard.SetActive(true);
        }

        if (Input.GetKey(KeyCode.K))
        {
            leaderBoard.SetActive(false);
        }
    }
}
