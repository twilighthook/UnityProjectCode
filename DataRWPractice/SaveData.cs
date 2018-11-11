using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveData : MonoBehaviour {

    void Start(){
        //建立一個player物件
        player p1 = new player();

        //設置p1內的各屬性
        p1.name = "Tom";
        p1.level = 50;
        p1.attack = 600;
        p1.defence = 200;

        equipment eq1 = new equipment();
        eq1.attack = 87;
        eq1.limitLevel = 50;
        eq1.equipmentName = "Excalibur";
        p1.equipment.Add(eq1);
        
        //將此player裡面的屬性轉成string(json格式)
        string saveString = JsonUtility.ToJson(p1);
        
        //將字串saveString存到硬碟中
        StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/GameJSONData", "Player1.json"));
        file.Write(saveString);
        file.Close();
    }

}
