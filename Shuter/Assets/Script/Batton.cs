﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batton : MonoBehaviour

{
    // Start is called before the first frame update
    
    public GameObject barier;
    SpriteRenderer Sprite;
    Collider2D Collider;

    void OnTriggerStay2D(Collider2D collision)             //Взаимодействия между областями и игроком по тегам
    {

        if (collision.gameObject.tag == "Player")    //Барьер выкл
        {
            Sprite.color = Color.green;
            Collider.isTrigger = true;

        }
         


    }

    void OnTriggerExit2D(Collider2D collision)             //Взаимодействия между областями и игроком по тегам
    {

        if (collision.gameObject.tag == "Player")    //Барьер вкл
        {
            Sprite.color = Color.red;
            Collider.isTrigger = false;

        }



    }

    private void Start()
    {
         Sprite = barier.GetComponent<SpriteRenderer>();
         Collider = barier.GetComponent<Collider2D>();
    }


}
