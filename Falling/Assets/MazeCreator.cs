using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCreator : MonoBehaviour
{
    // Start is called before the first frame update
    public int difficulty;
    public GameObject BarrierX; 
    public GameObject BarrierY; 
    void Start()
    {
       // difficulty = 30;
        CreateMaze(10,1000);
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void CreateMaze(int x, int y)
    {
        
        for (int i = 0; i < y; i++)
        {
            int tops = 0;
            int sides = 0;
            for (int j = 0; j < x; j++)
            {
                int chance = 100;
                chance -= tops;
                int hit = UnityEngine.Random.Range(0, chance);
                if (hit > difficulty)
                {
                    CreateTopBarrier(j, i);
                    tops += (100 / x);
                }
                if(sides < 3)
                {
                    hit = UnityEngine.Random.Range(0, chance);
                    if(hit-20 > difficulty)
                    {
                        CreateSideBarrier(j, i);
                    }
                }
            }
        }
    }

    private void CreateSideBarrier(int x, int y)
    {
        x *= 10;
        y *= 10;
        GameObject bar = Instantiate(BarrierY);
        bar.transform.position = new Vector3(x + 10, y + 5, 0);
    }

    private void CreateTopBarrier(int x, int y)
    {
        x *= 10;
        y *= 10;
        GameObject bar = Instantiate(BarrierX);
        bar.transform.position = new Vector3(x + 5f, y + 10, 0);
    }
}
