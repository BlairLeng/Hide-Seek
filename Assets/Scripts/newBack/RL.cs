﻿using System.Collections;
using System.Collections.Generic;
public class RL
{
    public int limit = 8;
    public int counter = 0;
    public RL(){
        return;
    }

    public void read(){
        return;
    }

    public string order(){
        //根据RL目前的信息，来判断要做什么
        if (counter++ < limit){
            return "left";
        }
        return "";
    }
}
