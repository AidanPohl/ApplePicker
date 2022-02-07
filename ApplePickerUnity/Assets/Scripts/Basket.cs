/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 2/1/2022
 * 
 * Last Edited: 2/7/2022
 * Last Edited By: Aidan Pohl
 * 
 * Description: Handles moving the basket and catching apples.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using UI Library

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score Counter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    } //end Start()


    // Update is called once per frame
    void Update()
    {
        //Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        //The Camera's z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;

        //Convert the point from 2D screen space into 3D game world space.
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //Move the x position of the Basket to the x position of the Mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }//end Update()

    void OnCollisionEnter (Collision coll){
        //Find out what hit the basket
        GameObject collidedWidth = coll.gameObject;
        if (collidedWidth.tag =="Apple"){
            Destroy (collidedWidth);

            //Increase score
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            //Update Highscore
            if(score > HighScore.highScore)
            {
                HighScore.highScore = score;
            }//end if(score < HighScore.score)

        }//end  if (collidedWidth.tag =="Apple")
    } //end void OnCollisionEnter (Collision coll)
}
