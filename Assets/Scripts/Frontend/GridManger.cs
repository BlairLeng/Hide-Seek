using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManger : MonoBehaviour
{

    // create temp_gameobject list
    // List<>...

    public List<GameObject> pool1 = new List<GameObject>();
    public Sprite sprite;
    public int[,] Grid;
    int Vertical, Horizontal, Columns, Rows;
  

    // Start is called before the first frame update
    void Start()
    {
        //Vertical = (int)Camera.main.orthographicSize;
        //Horizontal = Vertical * (Screen.width / Screen.height);
        //Columns = Horizontal * 2;
        //Rows = Vertical * 2;
        //Grid = new int[Columns, Rows];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                // Grid[i, j] = 1;
                //SpawnTile(j, i, 0,10);
            }
        }

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



    public void SpawnTileOrigin(int x, int y, int Value, int Height)
    {
        // every time you spawn, store it into temp list


        Sprite sp = Resources.Load<Sprite>("Sprites/Square");
        //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
        GameObject g = new GameObject("X" + x+ "Y"+(Height - y));
        g.transform.position = new Vector3(x-(Horizontal - 0.5f),y-(Vertical - 0.5f));
        var s = g.AddComponent<SpriteRenderer>(); 
        // Debug.Log("sprite should be "+ sp);
        s.sprite = sp;

    }
        // get x y and spwan the tile
        public void SpawnTile(int x,int y,int Value,int Height)
    {
        // every time you spawn, store it into temp list


        //Sprite sp = Resources.Load<Sprite>("Sprites/Square");
        //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
        //GameObject g = new GameObject("X" + x+ "Y"+(Height - y));
        //g.transform.position = new Vector3(x-(Horizontal - 0.5f),y-(Vertical - 0.5f));
        //var s = g.AddComponent<SpriteRenderer>(); 
       // Debug.Log("sprite should be "+ sp);
        //s.sprite = sp;
        if (Value == 0)
        {
            Sprite sp = Resources.Load<Sprite>("Sprites/grass");
            //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
            GameObject g = new GameObject("X" + x + "Y" + (Height - y));
            g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f));
            var s = g.AddComponent<SpriteRenderer>();
            // Debug.Log("sprite should be "+ sp);
            s.sprite = sp;
            s.color = new Color(1.0f, 1.0f, 1.0f);
            pool1.Add(g);
        }
        else if (Value == 1)
        {
            Sprite sp = Resources.Load<Sprite>("Sprites/wall");
            //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
            GameObject g = new GameObject("X" + x + "Y" + (Height - y));
            g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f));
            var s = g.AddComponent<SpriteRenderer>();
            // Debug.Log("sprite should be "+ sp);
            s.sprite = sp;
            s.color = new Color(0.0f, 0.0f, 0.0f);
            pool1.Add(g);
        }
        else if (Value == 2)
        {
            //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
            Sprite sp = Resources.Load<Sprite>("Sprites/yellowgrass");
            GameObject g = new GameObject("X" + x + "Y" + (Height - y));
            g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f));
            var s = g.AddComponent<SpriteRenderer>();
            // Debug.Log("sprite should be "+ sp);
            s.sprite = sp;
            //s.color = new Color(0.0f, 0.0f, 1.0f);
            //g.layer = LayerMask.NameToLayer("Spawn");
            pool1.Add(g);
        }
        else if (Value == 3)
        {
            Sprite sp = Resources.Load<Sprite>("Sprites/greengrass");
            //Sprite sp = Resources.Load<Sprite>("Sprites/ppp");
            GameObject g = new GameObject("X" + x + "Y" + (Height - y));
            g.transform.position = new Vector3(x - (Horizontal - 0.5f), y - (Vertical - 0.5f));
            var s = g.AddComponent<SpriteRenderer>();
            // Debug.Log("sprite should be "+ sp);
            s.sprite = sp;
            //s.color = new Color(1.0f, 0.0f, 0.0f);
            g.layer = 9;
            pool1.Add(g);
        }

        
        //pool1.Add(g);

        //Debug.Log("what's in the pool" + pool1);
    }

    public void Deletespawn()
    {
        for (int i = 0; i < pool1.Count; i++)
        {
            Destroy(pool1[i]);
        }
            return;
    }
}
