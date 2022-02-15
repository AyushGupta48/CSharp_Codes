﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RanAlien2 : MonoBehaviour
{
    public Animator anim; //Variables for alien movemement and orb movement
    public Animator animorb;
    public Animator anim1;
    public Animator animorb1;
    public Animator anim2;
    public Animator animorb2;
    public Animator anim3;
    public Animator animorb3;
    public Animator anim4;
    public Animator animorb4;
    public Animator anim5;
    public Animator animorb5;
    public Animator anim6;
    public Animator animorb6;
    public Animator anim7;
    public Animator animorb7;
    public Animator anim8;
    public Animator animorb8;
    public Animator anim9;
    public Animator animorb9;

    public static float healthAmount = 140; //health
    public GameObject healthDisplay;

    public GameObject GamelostPanel; //Losing screen

    public GameObject crosshair;
    void Start()
    {
        healthDisplay.GetComponent<Text>().text = "Health: " + healthAmount; //Displays health
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 110) == 1)
        {
            anim.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb.SetTrigger("OrbShot"); //Triggers the orb movement with it
            if (animorb.GetBool("OrbShot") == true)
            {
                healthAmount -= 10; //If shooting animation is played, decrease health by 10
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim1.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb1.SetTrigger("OrbShot1"); //Triggers the orb movement with it
            if (animorb1.GetBool("OrbShot1") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim2.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb2.SetTrigger("OrbShot2"); //Triggers the orb movement with it
            animorb2.SetTrigger("OrbShot2"); //Triggers the orb movement with it
            if (animorb2.GetBool("OrbShot2") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim3.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb3.SetTrigger("OrbShot3"); //Triggers the orb movement with it
            if (animorb3.GetBool("OrbShot3") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim4.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb4.SetTrigger("OrbShot4"); //Triggers the orb movement with it
            if (animorb4.GetBool("OrbShot4") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim5.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb5.SetTrigger("OrbShot5"); //Triggers the orb movement with it
            if (animorb5.GetBool("OrbShot5") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim6.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb6.SetTrigger("OrbShot6"); //Triggers the orb movement with it
            if (animorb6.GetBool("OrbShot6") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim7.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb7.SetTrigger("OrbShot7"); //Triggers the orb movement with it
            if (animorb7.GetBool("OrbShot7") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim8.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb8.SetTrigger("OrbShot8"); //Triggers the orb movement with it
            if (animorb8.GetBool("OrbShot8") == true)
            {
                healthAmount -= 10;
            }
        }

        if (Random.Range(1, 110) == 1)
        {
            anim9.SetTrigger("RanShootOrb"); //Triggers the shooting animation 
            animorb9.SetTrigger("OrbShot9"); //Triggers the orb movement with it
            if (animorb9.GetBool("OrbShot9") == true)
            {
                healthAmount -= 10;
            }
        }

        healthDisplay.GetComponent<Text>().text = "Health: " + healthAmount; //update the health amount depending on how many times player was shot

        if (healthAmount == 0)
        {
            Time.timeScale = 0;
            GamelostPanel.SetActive(true);
            healthDisplay.SetActive(false);
            Cursor.visible = true;
            crosshair.SetActive(false); //If health falls to 0 then losing screen is displayed
        }


    }
}
