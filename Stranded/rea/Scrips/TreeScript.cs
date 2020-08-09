using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    public float yDistanceForRenderPriority;
    public TreeSortedList TreeList;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
            //render in front of object
            if (collision.CompareTag("Player"))
            {
            print(TreeList.Order == null);
            TreeList.Order.Add(GetComponent<SpriteRenderer>().sortingOrder);
            updateSortingLayer(collision.GetComponent<Spriter2UnityDX.EntityRenderer>());

            }
            
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        {
            if (collision.CompareTag("Player"))
            {
                TreeList.Order.Remove(GetComponent<SpriteRenderer>().sortingOrder);
                updateSortingLayer(collision.GetComponent<Spriter2UnityDX.EntityRenderer>());
            }
           
        }
    }
    public void updateSortingLayer(Spriter2UnityDX.EntityRenderer renderer)
    {
        print(TreeList.Order.Count);
        if(TreeList.Order.Count == 0)
        {
            renderer.SortingLayerName = "Player";
            renderer.SortingOrder = 0;
        }
        else
        {
            renderer.SortingLayerName = "Trees";
            renderer.SortingOrder = TreeList.Order.Min -1;
        }

    }
}
