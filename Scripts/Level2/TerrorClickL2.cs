﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerrorClickL2 : MonoBehaviour
{
    public Animator anim1; //Calls upon the appropriate animation (in this case dying animation)
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    public Animator anim7;
    public Animator anim8;
    public Animator anim9;

    public GameObject bullet2; //Variable for the bullet attached to the enemy
    public GameObject bullet3;
    public GameObject bullet4;
    public GameObject bullet5;
    public GameObject bullet6;
    public GameObject bullet7;
    public GameObject bullet8;
    public GameObject bullet9;

    public GameObject Respawn1; //Variable for respawned enemy
    public GameObject Respawn2;
    public GameObject Respawn3;
    public GameObject Respawn4;
    public GameObject Respawn5;

    public GameObject winPanel; //win screen

    public Camera altcam; //Since we are not using the main camera as each map has its own camera, we need to specify an alternative camera for this code to run
    public InputField playername; //inputted name
    public GameObject namedisplay;

    public GameObject crosshair;

    private void Start()
    {
        namedisplay.GetComponent<Text>().text = "Player: " + playername.text; //show inputted name
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = altcam.ScreenPointToRay(Input.mousePosition); //Raycasts imaginary line from exact mouseposition

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null && bc.name == "Terrorist1L2")
                {
                    Debug.Log("Dead!"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim1.SetTrigger("ClickTerror"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f); //Destroys enemy after 3 seconds, allowing dying animation to complete

                    StartCoroutine(Wait1());


                }

                if (bc != null && bc.name == "Terrorist2L2")
                {
                    Debug.Log("Dead!11111"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim2.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet2.SetActive(false); //Destroy bullet
                }

                if (bc != null && bc.name == "Terrorist3L2")
                {
                    Debug.Log("Dead!3"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim3.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet3.SetActive(false);

                    StartCoroutine(Wait2());

                }

                if (bc != null && bc.name == "Terrorist4L2")
                {
                    Debug.Log("Dead!4"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim4.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet4.SetActive(false);

                    StartCoroutine(Wait3());

                }

                if (bc != null && bc.name == "Terrorist5L2")
                {
                    Debug.Log("Dead!5"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim5.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet5.SetActive(false);

                    StartCoroutine(Wait4());

                }

                if (bc != null && bc.name == "Terrorist6L2")
                {
                    Debug.Log("Dead!6"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim6.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet6.SetActive(false);

                    StartCoroutine(Wait5());

                }

                if (bc != null && bc.name == "Terrorist7L2")
                {
                    Debug.Log("Dead!7"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim7.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet7.SetActive(false);
                }

                if (bc != null && bc.name == "Terrorist8L2")
                {
                    Debug.Log("Dead!8"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim8.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet8.SetActive(false);
                }

                if (bc != null && bc.name == "Terrorist9L2")
                {
                    Debug.Log("Dead!9"); //Unity sends a message to me so I know that I clicked the enemy and the code is actually working

                    anim9.SetTrigger("ClickTerror2"); //Click is in the animator tab which handles the dying animation to be played

                    Destroy(bc.gameObject, 3f);
                    bullet9.SetActive(false);
                }


            }
        }
        //if player kills all enemies..
        if (GameObject.FindWithTag("TerroristL2") == null)
        {
            StartCoroutine(Next_Wave());
        }

    }
    //Winning screen is shown. For some reason I could not change the variable from anythging else but "Next_Wave" so i kept it as it is.
    IEnumerator Next_Wave()
    {
        yield return new WaitForSeconds(0.01f);
        winPanel.SetActive(true);
        Cursor.visible = true;
        crosshair.SetActive(false);
        
    }

    //After reseashing for maybe 1 week straight on how to play the next line of code in Unity after n seconds without the use of a coroutine, I came to no conclusion and solution in doing so
    //Thus, I created several coroutines which many of the robots are linked to which respawn an enemy after 1.2 seconds. Though this is quite tedious...it works!!!

    IEnumerator Wait1()
    {
        yield return new WaitForSeconds(1.3f);
        Respawn4.SetActive(true);
        bullet8.SetActive(true);
    }

    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn1.SetActive(true);
        bullet5.SetActive(true);
    }

    IEnumerator Wait3()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn2.SetActive(true);
        bullet6.SetActive(true);
    }

    IEnumerator Wait4()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn5.SetActive(true);
        bullet9.SetActive(true);
    }

    IEnumerator Wait5()
    {
        yield return new WaitForSeconds(1.3f);

        Respawn3.SetActive(true);
        bullet7.SetActive(true);
    }
}
