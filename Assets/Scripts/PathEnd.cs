using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathEnd : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerPosition>().NextPath();
        }
    }
}
