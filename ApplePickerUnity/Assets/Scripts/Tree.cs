/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 1/31/2022
 * 
 * Last Edited; N/A
 * Last Edited By: N/A
 * 
 * Description: Controls tree movement and apple spawning
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    /**VARIABLES**/
    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate < GameObject>(applePrefab);
        apple.transform.position = transform.position; //move apple to tree pos
        Invoke("DropApple", secondsBetweenAppleDrops);
    }
    // Update is called once per frame
    void Update()
    {
        //Movement of the tree
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Turn around at edges
        if (pos.x < -leftAndRightEdge) //at left edge
        {
            speed = Mathf.Abs(speed);//move right
        }
        else if (pos.x > leftAndRightEdge)//at right edge
        {
            speed = -Mathf.Abs(speed); //move left
        } //end else-if
    }//end Update

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)//randomly change directions
        {
            speed *= -1;//change directions
        }//end if(Random.value < chanceToChangeDirections)
    }//end FixedUpdate()

}//end class
