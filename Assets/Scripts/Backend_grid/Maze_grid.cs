using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_grid: Basic_grid{
    // this shows how for each [x,y], what do we have on top
    public int[,] grids; 
    public Maze_grid(int x, int y){
        setPosition(x,y);
        this.grids = new int[y, x];
    }

    public void setGrid(int x, int y, int type){
        this.grids[y,x] = type;
    }

    public string ToString()
    {
        return "this is a maze with " + y + "and" + x + " large";
    }
    
}
