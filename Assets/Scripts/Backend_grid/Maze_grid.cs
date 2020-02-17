using System.Collections;
using System.Collections.Generic;

public class Maze_grid: Basic_grid{
    // this shows how for each [x,y], what do we have on top
    //public int[,] grids;
    public List<List<Basic_grid>> grids = new List<List<Basic_grid>>();
    public Maze_grid(int x, int y){
        setPosition(x,y);
    }

    //public void setGrid(int x, int y, int type){
    //    this.grids[y,x] = type;
    //}

    public void setWall(int x, int y)
    {
        Wall_grid wall = new Wall_grid(0, 0);
        this.grids[x][y] = wall;
    }

    public string ToString()
    {
        return "this is a maze with " + y + "and" + x + " large";
    }
    
}
