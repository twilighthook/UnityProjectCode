using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataSave : MonoBehaviour {

    player1 p1 = new player1();

    void Start(){
        saveData("Tom" , 20 , 250);
        string saveString = JsonUtility.ToJson(p1);
        //將字串saveString存到硬碟中
        StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/Resources/GameJSONData", "Player1.json"));
        file.Write(saveString);
        file.Close();
    }

    private void saveData(string name , int level , int attack){
        p1.name = name;
        p1.level = level;
        p1.attack = attack;
    }

}
