using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    List<Dictionary
        <string, object>> _tileData;

    // Use this for initialization
    void Start () {
        _tileData = CSVReader.Read("tile");
    }

    // Update is called once per frame
    void Update () {
	}
}
