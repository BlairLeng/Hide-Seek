using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_grid{
    // this shows how many different numbers we want to have on x axis and y axis
    public int x = 0;
    public int y = 0;
    // this shows how for each [x,y], what do we have on top
    public int[,] grids = new int[y,x];
    public Maze_grid(int x, int y){
        this.x = x;
        this.y = y;
    }

    public void setGrid(int x, int y, int type){
        this.grids[y,x] = type;
    }
    
}
