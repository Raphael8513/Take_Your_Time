using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Slider generalBar;
    public Slider sleep_slider;
    public Slider tire_slider;
    public Slider anxiety_slider;   

    public void setBar(int num)
    {
        generalBar.value = num;
    }



    public void reset()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
