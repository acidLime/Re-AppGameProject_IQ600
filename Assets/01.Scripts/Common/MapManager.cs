using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    Tile[,] tile;
    public Texture2D[] tileImage;
    int mapSize = 8;
    private void Awake()
    {
        tile = new Tile[mapSize, mapSize];
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Init()
    {
        for(int i = 0; i < mapSize; i++)
        {
            for(int j = 0; j < mapSize; j++)
            {

            }
        }
    }
}
