using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public GameObject NoteBox;
    public Text NoteText;
    public string num;

    private bool playerItem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Taker"))
        {
            NoteBox.SetActive(true);
            playerItem = true;
        }

    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Taker"))
        {
            NoteBox.SetActive(false);
            playerItem = false;
        }

    }



}
