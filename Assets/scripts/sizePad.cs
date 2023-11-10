using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizePad : MonoBehaviour
{
    [SerializeField] string itemName;
    public Vector3 smallScale = new Vector3(0.5f, 1.0f, 1.0f);
    public Vector3 mediumScale = new Vector3(1.0f, 2.0f, 1.0f);
    public Vector3 largeScale = new Vector3(2.0f, 4.0f, 1.0f);

    void OnTriggerEnter2D(Collider2D hit){
        if(hit.gameObject.name == "player"){
            if(itemName == "small"){
                hit.GetComponent<playerController>().changeSize(smallScale);
            }
            else if(itemName == "medium"){
                hit.GetComponent<playerController>().changeSize(mediumScale);
            }
            else{
                hit.GetComponent<playerController>().changeSize(largeScale);
            }
        }
    }
}
