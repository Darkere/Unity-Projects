using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        BuildTerrain();
	}

    private void BuildTerrain()
    {
        //make terrain

        GenerateHeightmap();
    }

    private void GenerateHeightmap()
    {
       //???
    }

    // Update is called once per frame
    void Update () {
		
	}
}
