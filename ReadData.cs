using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadData : MonoBehaviour {

    player1 p1 = new player1();

    // Use this for initialization
    void Start () {

        StreamReader fileReader = new StreamReader(System.IO.Path.Combine("Assets/Resources/GameJSONData", "Player1.json"));
        string loadJson = fileReader.ReadToEnd();
        fileReader.Close();

        p1 = JsonUtility.FromJson<player1>(loadJson);

        print("Name:" + p1.name);

    }

}
