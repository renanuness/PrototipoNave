using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    private int _position;
    private Player _player;
    private PathGenerator _path;

	private void Start ()
    {
        transform.position = new Vector3(-76, 0, 0);
        _position = 0;    	
	}
	
    public void NextPath()
    {
        _position++;
        _path.InstantiateNewPathItem(_position);
    }
}
