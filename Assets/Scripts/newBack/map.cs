﻿using System.Collections;
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
    }

    public void addWalls()
    {
        return;
    }

    //void Start()
    //{
    //    map map = new map(10,10);
    //    string json = JsonUtility.ToJson(map);
    //    Debug.Log(json);
    //}

}
