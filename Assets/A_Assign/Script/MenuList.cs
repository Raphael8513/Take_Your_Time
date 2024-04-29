using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscUI : MonoBehaviour
{
    public GameObject menuList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            menuList.SetActive(true);
        }
    }
    void edit()
    {
        int n = 0;
        int t = 9;
        for (n = 0; n < t; n++)
        {
        }
    }


    
}
