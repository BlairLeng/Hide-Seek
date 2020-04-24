using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class map: MonoBehaviour
{
    //要先创建一个map的object，在里面加入wall和runner，所以runner和wall都可以继承它

    //在map里面，需要定义当前map的大小

    public int width;
    public int height;
    public List<gridData> grids = new List<gridData>();

    //因为2d的list在c#里面没办法jsonify，而且我不想去改源码。。。所以就变成了1d的list
    //需要自己去做一下分割
    // 0 代表可以走的位置
    // 1 代表墙
    // 2 代表人
    // 3 代表抓人的人

    private List<gridData> runners = new List<gridData>();
    private List<gridData> chasers = new List<gridData>();

    public map(int width, int height)
    {
        this.width = width;
        this.height = height;
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < height; i++)
            {
                gridData empty = new gridData(i,j);
                this.grids.Add(empty);
            }
        }
        this.addRunners(9,0);
        this.addChaser(9,1);
    }

    public void addRunners(int x, int y){
        gridData runner = new gridData(x,y,2,0,this.width,this.height);
        int pos = x + y * this.width;
        this.grids[pos] = runner;
        this.runners.Add(runner);
    }

    public void addChaser(int x, int y){
        gridData chaser = new gridData(x,y,3,0,this.width,this.height);
        int pos = x + y * this.width;
        this.grids[pos] = chaser;
        this.chasers.Add(chaser);
    }

    public List<gridData> getRunners(){
        return this.runners;
    }

    public void addWalls(int x, int y)
    {
        gridData wall = new gridData(x,y,1,1,this.width,this.height);
        int pos = x + y * this.width;
        this.grids[pos] = wall;
        return;
    }

    public void runnerMove(int serialNumber, string direction){
        int pos = this.runners[serialNumber].y * this.width + this.runners[serialNumber].x;
        gridData empty = new gridData(this.runners[serialNumber].x, this.runners[serialNumber].y);
        this.grids[pos] = empty;
        int pseudo_pos = this.runners[serialNumber].pseudoMove(direction);
        //如果移动后的结果是chaser，那么就要死亡了
        if (this.grids[pseudo_pos].type != 3 && this.grids[pseudo_pos].type == 0){
            this.runners[serialNumber].move(direction);
            pos = this.runners[serialNumber].y * this.width + this.runners[serialNumber].x;
            this.grids[pos] = this.runners[serialNumber];
        }
        else{
            this.runners[serialNumber].die();
        }
        return;
    }

    public void chaserMove(int serialNumber, string direction){
        int pos = this.chasers[serialNumber].y * this.width + this.chasers[serialNumber].x;
        gridData empty = new gridData(this.chasers[serialNumber].x, this.chasers[serialNumber].y);
        this.grids[pos] = empty;

        int pseudo_pos = this.runners[serialNumber].pseudoMove(direction);
        //如果移动后的结果是runner，那么就要吃掉
        if (this.grids[pseudo_pos].type != 3 && this.grids[pseudo_pos].type != 1){
            this.chasers[serialNumber].move(direction);
            pos = this.chasers[serialNumber].y * this.width + this.chasers[serialNumber].x;
            this.grids[pos] = this.chasers[serialNumber];
        }
        if (this.grids[pseudo_pos].type == 2){
            this.chasers[serialNumber].kill();
        }
        return;
    }

    public void read(){
        //讲read的结果发给rl模型，read的结果可以为地图信息或其他相关信息
        return;
    }


    //void Start()
    //{
    //    map map = new map(10,10);
    //    string json = JsonUtility.ToJson(map);
    //    Debug.Log(json);
    //}

}
