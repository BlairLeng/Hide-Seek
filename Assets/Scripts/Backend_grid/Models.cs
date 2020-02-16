using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Models : MonoBehaviour
{
    // Start is called before the first frame update
    public Maze_grid maze = new Maze_grid(10, 10);
    public Wall_grid[] walls = new Wall_grid[20];

    public void addWalls()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                maze.setWall(i, j);
            }
        }
    }
}
