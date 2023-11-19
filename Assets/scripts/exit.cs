using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){
            Managers.Mission.GoToNext();
        }
    }
}
