using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTileScript : MonoBehaviour    
{
    
    public int tileX;
    public int tileY;
   
    public GameObject unitOnTile;
    public tileMapScript map;


    /*
     * This was used in Quill18Create'sTutorial, I no longer use this portion
    private void OnMouseDown()
    {
       
        Debug.Log("tile has been clicked");
        if (map.selectedUnit != null)
        {
            map.generatePathTo(tileX, tileY);
        }
        
    }*/
}
