using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] string itemName;

    void OnTriggerEnter2D(Collider2D hit){
        Destroy(this.gameObject);
    }
}
