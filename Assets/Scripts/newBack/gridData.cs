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
        int isEmpty = this.accessible_directions.Count;
        if ((type == 2 || type == 3) && isEmpty != 0 && this.accessible_directions.Contains(direction)){
            move(direction);
        }
        return;
    }

    private void move(string direction){
        if (direction == "east"){
            this.x += 1;
        }
        else if (direction == "west"){
            this.x -= 1;
        }
        else if (direction == "up"){
            this.y -= 1;
        }
        else if (direction == "down"){
            this.y += 1;
        }
    }

    private void checkAccessbility(){
        //四角
        if (this.x == this.map_width && this.y == this.map_height){
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("up");
        }
        if (this.x == this.map_width && this.y == 0){
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("down");
        }
        if (this.x == 0 && this.y == 0){
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("down");
        }
        if (this.x == 0 && this.y == this.map_height){
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("up");
        }
        //四边
        else if(this.y == 0 && this.x != 0  && this.x != this.map_width){
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("down");
        }
        else if(this.y == this.map_height && this.x != 0  && this.x != this.map_width){
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("up");
        }
        else if(this.x == this.map_width && this.y != this.map_height && this.y != this.map_height){
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("up");
            this.accessible_directions.Add("down");
        }
        else if(this.x == 0 && this.y != this.map_height && this.y != this.map_height){
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("up");
            this.accessible_directions.Add("down");
        }
        else{
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("up");
            this.accessible_directions.Add("down");
        }
    }
}
