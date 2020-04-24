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

    public void move(string direction){
        // 可以设置是否可以移动的判断条件
        // 如果是runner或者chaser允许移动
        int isEmpty = this.accessible_directions.Count;
        if ((type == 2 || type == 3) && isEmpty != 0 && this.accessible_directions.Contains(direction)){
            r_move(direction);
        }
        return;
    }

    private void r_move(string direction){
        if (direction == "right"){
            this.x += 1;
        }
        else if (direction == "left"){
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
        //左上角为(0,0)点
        //  0,0  1,0  2,0 ...
        //  0,1  1,1  2,1 ...
        //  0,2  1,2  2,2 ...
        //  ...  ...  ...
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
        //常规
        else{
            this.accessible_directions.Add("right");
            this.accessible_directions.Add("left");
            this.accessible_directions.Add("up");
            this.accessible_directions.Add("down");
        }
    }

    public void die(){
        return;
    }

    public void kill(){
        return;
    }

    public int pseudoMove(string direction){
        int isEmpty = this.accessible_directions.Count;
        if ((type == 2 || type == 3) && isEmpty != 0 && this.accessible_directions.Contains(direction)){
            return pseudo_r_move(direction);
        }
        return -1;
    }

    private int pseudo_r_move(string direction){
        if (direction == "right"){
            return this.y * this.map_width + (this.x+1);
        }
        else if (direction == "left"){
            return this.y * this.map_width + (this.x-1);
        }
        else if (direction == "up"){
            return (this.y-1) * this.map_width + this.x;
        }
        else if (direction == "down"){
            return (this.y+1) * this.map_width + this.x;
        }
        return -1;
    }

}
