using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public  Texture2D Arr;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(Arr, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
