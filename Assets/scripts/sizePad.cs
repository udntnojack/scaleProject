using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizePad : MonoBehaviour
{
    [SerializeField] string itemName;

    void OnTriggerEnter2D(Collider2D hit){
        if(hit.gameObject.name == "player"){
            hit.GetComponent<playerController>().changeSize();
        }
    }
}
