/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 2/7/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Runs the High Scoring System
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int highScore = 1000;
    //Awake is called before Start()
    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", highScore);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + highScore;

        if (highScore > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",highScore);
        }
       
    }
}
