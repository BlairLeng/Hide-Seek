using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class basic
{
    //位置
    public int x = 0;
    public int y = 0;

    // 1 代表不可穿过
    // 0 代表可以穿过
    // -1 代表separate
    public int collide = 0;

    //-1 is separate
    //0 is empty 
    //1 is wall
    //2 is runner
    //3 is chaser 
    public int type = 0;

    //...
}
