using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Basic;

public class Wall_grid: Basic_grid{
    // collide = 1 证明该物品会被collide到
    public int collide = 1;
    public Wall_grid(int x, int y){
        pos_x = x;
        pos_y = y;
    }
    
}
