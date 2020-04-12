using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class gridData: basic
{
    private int map_width;
    private int map_height;
    private List<string> accessible_directions = new List<string>();

    public gridData(int x, int y){
        this.x = x;
        this.y = y;
    }

    public gridData(int x, int y, int type, int collide, int map_width, int map_height){
        this.x = x;
        this.y = y;
        this.collide = collide;
        this.type = type;
        this.map_width = map_width;
        this.map_height = map_height;
        if (type == 2 || type == 3){
            this.checkAccessbility();
        }
    }

    public void c_move(string direction){
        // 可以设置是否可以移动的判断条件
        // 如果是runner或者chaser允许移动
        if (type == 2 || type == 3){
            move(direction);
        }
        return;
    }

    private void move(string direction){

    }

    private void checkAccessbility(){
        if (this.x == this.map_height){
            
        }
    }
}
