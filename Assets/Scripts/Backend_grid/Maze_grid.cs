using System.Collections;
using System.Collections.Generic;

public class Maze_grid: Basic_grid{
    // this shows how for each [x,y], what do we have on top
    //public int[,] grids;
    public List<List<int>> grids = new List<List<int>>();
    public Maze_grid(int x, int y){
        setPosition(x,y);
    }

    //public void setGrid(int x, int y, int type){
    //    this.grids[y,x] = type;
    //}

    public void setWall()
    {   
        for (int j = 0; j < 4; j++){
            List<int> sublist = new List<int>();
            for (int i = 0; i < 4; i++){
                sublist.Add(1);
            }
            this.grids.Add(sublist);
        }
    }

    public void addWalls()
    {
        this.setWall();
        // for (int i = 0; i < 4; i++)
        // {
        //     for (int j = 0; j < 4; j++)
        //     {
        //         this.setWall(i, j);
        //     }
        // }
    }

    public override string ToString()
    {
        string r = "";
        foreach (var sublist in this.grids)
        {
            foreach (var value in sublist)
            {
                r += value;  
            }
        }
        return r;
        // return "this is a maze with " + y + "and" + x + " large";
    }
    
}
