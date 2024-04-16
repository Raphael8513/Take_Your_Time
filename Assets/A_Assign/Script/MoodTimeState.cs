using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodTimeState : MonoBehaviour
{
    // Start is called before the first frame update

    public static int anxiety = 0;
    public static int tire = 0;
    public static int sleep = 0;
    public static int maxTime = 37;
    public static int currentTime = 50;
    public Bar sleep_bar;
    public Bar tire_bar;
    public Bar anxiety_bar;
    

    public Bar abar;
    public Bar bbar;
    public Bar cbar;
    public Bar dbar;
    public Bar ebar;

    public void ScoreToStateAstroids(int score)
    {
        int anxiety_change = 1;
        int tire_change = 2;
        //......
        anxiety += anxiety_change;
        tire += tire_change;
        anxiety_bar.setBar(anxiety);
        tire_bar.setBar(tire);
    }

    public void TimeToBar(int currentTime)
    {
        if ( currentTime > 0 &&  currentTime < 13 )
        {
            abar.setBar(currentTime);
            bbar.setBar(0);
            cbar.setBar(0);
            dbar.setBar(0); 
            ebar.setBar(0);
        }
        else if ( currentTime < 25 )
        {
            abar.setBar(12);
            bbar.setBar(currentTime-12);
            cbar.setBar(0);
            dbar.setBar(0); 
            ebar.setBar(0);
        }
        else if ( currentTime < 37 )
        {
            abar.setBar(12);
            bbar.setBar(12);
            cbar.setBar(currentTime-24);  
            dbar.setBar(0); 
            ebar.setBar(0);        
        }
        else if ( currentTime < 49 )
        {
            abar.setBar(12);
            bbar.setBar(12);
            cbar.setBar(12); ;
            dbar.setBar(currentTime-36); 
            ebar.setBar(0); 
        }
        else if ( true)
        {
            abar.setBar(12);
            bbar.setBar(12);
            cbar.setBar(12);
            dbar.setBar(12); 
            ebar.setBar(currentTime-48);
        }
    }

    void Start()
    {
        TimeToBar(currentTime-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
