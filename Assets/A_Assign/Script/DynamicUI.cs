using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicUI : MonoBehaviour
{
    public GameObject EscList;
    public GameObject StateList;
    [SerializeField] private bool EscList_active = false;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(EscList_active)
        {
            if(Input.GetKeyUp(KeyCode.Escape))
            {
                EscList.SetActive(false);
                EscList_active = false;
            }
        }
        else if(Input.GetKeyUp(KeyCode.Escape))
        {
                EscList.SetActive(true);
                EscList_active = true;

        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            StateList.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            StateList.SetActive(false);
        }
       // StateList.SetActive(false);

    }
}
