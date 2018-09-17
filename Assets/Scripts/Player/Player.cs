using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private PlayerPosition _playerPosition;

	private void Start ()
    {
        _playerPosition = GetComponent<PlayerPosition>();	
	}
	
	private void Update () {
		
	}
}
