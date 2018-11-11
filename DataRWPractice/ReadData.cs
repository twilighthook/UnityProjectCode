using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadData : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
        player p1 = new player();

        //做一個讀取器
        StreamReader fileReader = new StreamReader(System.IO.Path.Combine("Assets/GameJSONData", "Player1.json"));
        string stringJson = fileReader.ReadToEnd();
        fileReader.Close();

        //將讀取的string改成player物件型態
        p1 = JsonUtility.FromJson<player>(stringJson);

        print("Name:" + p1.name);

    }

}
