using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eTileType
{
    START,
    END,
    NORMAL,
    BLOCK,
    SLOW,
    TRAP,
}
public enum eTileDir
{
    NONE,
    UP,
    DOWN,
    LEFT,
    RIGHT,
}
public class Tile : MonoBehaviour {

    Vector2 _tilePosition;
    bool _canDraw = true;
    eTileType _tileType;
    eTileDir _tileDir;

    public Vector2 TilePosition
    {
        get
        {
            return _tilePosition;
        }
        set
        {
            _tilePosition = value;
        }
    }
    public bool CanDraw
    {
        get
        {
            return _canDraw;
        }
        set
        {
            _canDraw = value;
        }
    }
    public eTileType TileType
    {
        get
        {
            return _tileType;
        }
        set
        {
            _tileType = value;
        }
    }
    public eTileDir TileDir
    {
        get
        {
            return _tileDir;
        }
        set
        {
            _tileDir = value;
        }
    }
}
