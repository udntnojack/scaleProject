using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hit){
        if(hit.gameObject.name == "player"){
            hit.GetComponent<playerController>().onLadder = true;
        }
    }
    void OnTriggerExit2D(Collider2D hit){
        hit.GetComponent<playerController>().onLadder = false;
    }
}
