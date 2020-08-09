using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOrdering : MonoBehaviour
{
    List<Transform> TreeList;
    // Start is called before the first frame update
    void Start()
    {
        TreeList = new List<Transform>();
        foreach(Transform child in transform)
        {
            TreeList.Add(child);
        }

        TreeList.Sort((t1, t2) =>
        {
            float x = t1.position.y;
            float y = t2.position.y;
            if (x > y) return -1;
            if (x < y) return 1;
            else return 0;
        });
        int sorter = 2;
        foreach(Transform t in TreeList)
        {
            t.gameObject.GetComponent<SpriteRenderer>().sortingOrder = sorter;
           sorter += 2;
        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
