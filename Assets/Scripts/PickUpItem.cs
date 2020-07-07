using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PickUpItem : MonoBehaviour
{
    public GameObject winMsg;
    public GameObject scoreMsg;
    // public GameObject coin;

    public int score=0;


    void Update()
    {
       RaycastHit hit;

       if(Physics.Raycast(transform.position, transform.forward, out hit, 2f)) 
       {
           if(hit.transform.GetComponent<Coin>().isCoin==true && Input.GetKey("e"))
           {
               score++;
               String sc="Score ";
               sc += score.ToString();
               scoreMsg.GetComponent<Text>().text=sc;
                Debug.Log(sc);
               Destroy(hit.transform.gameObject);
           }
       } 

       if(score == 10)
       {
        //    win
        GetComponent<PlayerMove>().enabled = false;
        winMsg.SetActive(true);
       }

       Debug.Log(score);
    }
}
