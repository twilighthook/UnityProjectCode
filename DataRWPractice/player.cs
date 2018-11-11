using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class player {

    public string name;
    public int level;
    public float attack;
    public float defence;
    public List<equipment> equipment = new List<equipment>();

    public void setName(string name){
        this.name = name;
    }

    public string getName(){
        return this.name;
    }

}
