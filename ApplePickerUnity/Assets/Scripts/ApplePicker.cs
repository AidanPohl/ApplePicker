/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 2/1/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Creates the Basket
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    /**VARIABLES**/
    public GameObject basketPrefab;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i<numBasket; i++){
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
          }//End for (int i=0; i<numBaskets; i++)
        
    }//End Start()

    // Update is called once per frame
    void Update()
    {
        
    }
}
