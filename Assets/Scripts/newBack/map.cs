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

    private List<gridData> runners = new List<gridData>();
    //因为2d的list在c#里面没办法jsonify，而且我不想去改源码。。。所以就变成了1d的list
    //需要自己去做一下分割
    // 0 代表可以走的位置
    // 1 代表墙
    // 2 代表人
    // 3 代表抓人的人

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
        this.addRunners(3,3);
    }

    public void addRunners(int x, int y){
        gridData runner = new gridData(x,y,2,0,this.width,this.height);
        int pos = x + y * this.width;
        this.grids[pos] = runner;
        this.runners.Add(runner);
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
        Debug.Log(pos);
        gridData empty = new gridData(this.runners[serialNumber].x, this.runners[serialNumber].y);
        this.grids[pos] = empty;
        Debug.Log(grids[pos].type);
        Debug.Log(grids[pos].x);
        Debug.Log(grids[pos].y);

        this.runners[serialNumber].c_move(direction);
        pos = this.runners[serialNumber].y * this.width + this.runners[serialNumber].x;
        Debug.Log(pos);
        Debug.Log(this.runners[serialNumber].x);
        Debug.Log(this.runners[serialNumber].y);
        this.grids[pos] = this.runners[serialNumber];
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
