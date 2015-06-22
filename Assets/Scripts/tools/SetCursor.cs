using UnityEngine;
using System.Collections;

public class SetCursor : MonoBehaviour {

	// Use this for initialization
    public Texture2D[] cursor;
    Vector2 hotSpot = Vector2.zero;
    public int currentCur = 0; 

	void Start () {
        Cursor.SetCursor(cursor[0], hotSpot, CursorMode.Auto);
	}
	
 
	void Update () {
        if(currentCur==0)
        {
            Cursor.SetCursor(cursor[0], hotSpot, CursorMode.Auto);
        }else if(currentCur==1)
        {
            Cursor.SetCursor(cursor[1], hotSpot, CursorMode.Auto);
        }
        else if(currentCur==2)
        {
            Cursor.SetCursor(cursor[2], hotSpot, CursorMode.Auto);
        }
       
	}
}
