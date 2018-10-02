using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_iTween : MonoBehaviour {
    
    public Vector3 prev;
    public bool finish = false;
    readonly int FPS = 100;

    // Use this for initialization
    void Start () {
        MoveTo();
        StartCoroutine(RotateObject());
    }

    IEnumerator RotateObject(){
        prev = transform.position;
        while (!finish){
            yield return new WaitForSeconds((float) 1 / FPS);
            Vector3 direc = transform.position - prev;
            transform.eulerAngles = new Vector3(0 , Mathf.Atan2(direc.x, direc.z) * Mathf.Rad2Deg , 0);
            prev = transform.position;
        }
    }

    void ChangeFinishTag(){
        finish = true;
    }

    void MoveTo(){
        Hashtable moveSetting = new Hashtable();
        moveSetting.Add("time", 5.0f);
        moveSetting.Add("easetype", iTween.EaseType.linear);
        moveSetting.Add("path", iTweenPath.GetPath("PathTest"));
        moveSetting.Add("oncomplete", "changeFinishTag");

        iTween.MoveTo(this.gameObject , moveSetting);
    }

}
