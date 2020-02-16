using System.Collections;
using System.Collections.Generic;

public class Maze_grid: Basic_grid{
    // this shows how for each [x,y], what do we have on top
    //public int[,] grids;
    public List<List<T>> grids = new List<List<T>>();
    public Maze_grid(int x, int y){
        setPosition(x,y);
        this.grids = new int[y, x];
    }

    //public void setGrid(int x, int y, int type){
    //    this.grids[y,x] = type;
    //}

    public void setWall(int x, int y)
    {
        Wall_grids wall = new Wall_grids(0, 0);
        this.grids[x][y] = wall;
    }

    public string ToString()
    {
        return "this is a maze with " + y + "and" + x + " large";
    }
    
}
