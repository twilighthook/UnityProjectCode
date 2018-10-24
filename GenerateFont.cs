using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateFont : MonoBehaviour {

    GameObject damageCanvas;
    Text damageText;
    int criticalHit;

    void Start(){
        damageCanvas = Resources.Load("DamageCanvas", typeof(GameObject)) as GameObject;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)){
            criticalHit = Random.Range(1,10);
            damageText = damageCanvas.transform.Find("DamageText").gameObject.GetComponent<Text>();
            if (criticalHit == 1){
                damageText.color = Color.red;
                damageCanvas.transform.localScale = new Vector3(3f, 3f, 3f);
            }
            else{
                damageText.color = Color.white;
                damageCanvas.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            }
            Instantiate(damageCanvas, transform);
        }
    }

}
