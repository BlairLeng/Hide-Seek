
namespace Test{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class controller : MonoBehaviour
    {
        // public static void function(){
        //     Model m = new Model();
        //     Maze_grid maze = m.Maze;
        // }

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("here");
            Model m = new Model();
            Maze_grid maze = m.Maze;
            Debug.Log(maze.ToString());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}