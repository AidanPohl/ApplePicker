/***
 * Created by: Aidan Pohl (1539290)
 * Date Created: 2/1/2022
 * 
 * Last Edited: 2/7/2022
 * Last Edited By: Aidan Pohl
 * 
 * Description: Creates the Basket
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    [Header("Set in Inspector")]
    /**VARIABLES**/
    public GameObject basketPrefab;
    public int numBasket = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i=0; i<numBasket; i++){
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
          }//End for (int i=0; i<numBaskets; i++)
        
    }//End Start()

    // Update is called once per frame
    void Update(){}

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }//end foreach(GameObject tGO in tAppleArray)
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if(basketList.Count == 0)
        {
            SceneManager.LoadScene("Scene_0");
        }
    }//end AppleDestroyed()
}
