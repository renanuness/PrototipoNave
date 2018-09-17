using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PathGenerator : MonoBehaviour
{
    private List<int> paths = new List<int>(); // List with real path
    private List<GameObject> pathItens = new List<GameObject>(); // List with prefabs
    private float _time;
    private float _timeToChange = 5;
    private int currentPosition = 0;
    private void Start()
    {
        GetItens();
        StartPath();
        InstantiateNextThree(0);
    }

    private void Update()
    {
        //_time += Time.deltaTime;
        //if(_time > _timeToChange)
        //{
        //    _time = 0;
        //    InstantiateNewPathItem(currentPosition);
        //    currentPosition++;
        //}
    }

    private void GetItens()
    {
        var objects = Resources.LoadAll("Path", typeof(GameObject));

        pathItens.Clear();
        foreach(var go in objects)
        {
            var prefab = go as GameObject;
            pathItens.Add(prefab);
        }
    }

    private void StartPath()
    {
        paths.Clear();
        for(int i = 0; i < 100; i++)
        {
            paths.Add(Random.Range(0,5));
        }
    }

    public void InstantiateNewPathItem(int pos)
    {
        Vector3 position = new Vector3(0, 0, 0);
        if (pos > 0)
        {
            position.x = 150 * pos;
        }

        var go = Instantiate(pathItens[paths[pos]], position, Quaternion.identity);
    }
    
    private void InstantiateNextThree(int pos)
    {
        Vector3 position = new Vector3(0, 0, 0);
        if (pos > 0)
        {
            position.x = 150 * pos;
        }
        for(int i = 0; i < 3; i++)
        {
            position.x = 150 * pos;
            var go = Instantiate(pathItens[paths[pos]], position, Quaternion.identity);
            pos++;
        }
    }
}
