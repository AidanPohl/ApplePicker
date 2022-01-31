/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 1/31/2022
 * 
 * Last Edited; N/A
 * Last Edited By: N/A
 * 
 * Description: Controls apple despawning
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    /**Variable**/
    public static float bottomY = -20f;
    

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
