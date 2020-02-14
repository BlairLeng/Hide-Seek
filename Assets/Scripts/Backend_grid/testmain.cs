using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmain : MonoBehaviour
{
    // Start is called before the first frame update
    public Maze_grid maze = new Maze_grid(10,10);
    void Start()
    {
        Debug.Log(maze.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
