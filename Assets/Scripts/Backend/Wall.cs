using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Basic;

public class Wall: Basic{
    // collide = 1 证明该物品会被collide到
    public int collide = 1;
    public Wall(int x, int y){
        pos_x = x;
        pos_y = y;
    }
    
}
