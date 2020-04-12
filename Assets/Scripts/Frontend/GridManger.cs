using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManger : MonoBehaviour
{
    public Sprite sprite;
    public int[,] Grid;
    int Vertical, Horizontal, Columns, Rows;

    // Start is called before the first frame update
    void Start()
    {
        Vertical = (int)Camera.main.orthographicSize;
        Horizontal = Vertical * (Screen.width / Screen.height);
        Columns = Horizontal * 2;
        Rows = Vertical * 2;
        Grid = new int[Columns, Rows];
        
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < Columns; i++)
        //{
        //    for (int j = 0; j < Rows; j++)
        //    {
        //        Grid[i, j] = 1;
        //        SpawnTile(i, j, 1);
        //    }
        //}
        //SpawnTile(0, 1, 1);
    }

    // get x y and spwan the tile
    public void SpawnTile(int x,int y,int Value)
    {
        Sprite sp = Resources.Load<Sprite>("Sprites/Square");
        GameObject g = new GameObject("X" + x+ "Y"+y);
        g.transform.position = new Vector3(x-(Horizontal - 0.5f),y-(Vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>(); 
        //Debug.Log("sprite should be "+ sp);
        s.sprite = sp;
        if (Value == 0)
        {
            s.color = new Color(1.0f, 1.0f, 1.0f);
        }
        else if (Value == 1)
        {
            s.color = new Color(0.0f, 0.0f, 0.0f);
        }

    }

    public void spawnentire()
    {
        return;
    }
}
