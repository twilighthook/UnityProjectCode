using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageFont : MonoBehaviour {
    
    GameObject damageFont;
    Text damage;
    Hashtable moveSetting;
    Vector3[] damagePath = new Vector3[3];
    CanvasGroup CGfont;

    // Use this for initialization
    void Start () {

        //get the componment
        damageFont = transform.Find("DamageText").gameObject;
        CGfont = GetComponent<CanvasGroup>();

        DamageMoveSetting();

        //set the damage
        damage = damageFont.GetComponent<Text>();
        damage.text = Random.Range(75000, 105000).ToString();

        iTween.MoveTo(this.gameObject, moveSetting);

        StartCoroutine("fadeFont");
    }

    IEnumerator fadeFont(){
        while(true){
            //每次延遲0.1秒
            yield return new WaitForSeconds(0.1f);
            //減少透明度15%
            CGfont.alpha -= 0.15f;
            //將大小改變成80%
            transform.localScale = new Vector3(transform.localScale.x * 0.8f , transform.localScale.y * 0.8f, transform.localScale.z * 0.8f);
        }
    }

    void DamageMoveSetting(){
        moveSetting = new Hashtable();
        //移動時間設為兩秒
        moveSetting.Add("time" , 2.0f);
        //將移動方式設置成逐漸減速
        moveSetting.Add("easetype", iTween.EaseType.easeOutQuart);

        //設置三個移動path node為
        damagePath[0] = new Vector3(transform.position.x, transform.position.y , transform.position.z);
        damagePath[1] = new Vector3(transform.position.x + 2, transform.position.y + 1, transform.position.z + 0.25f);
        damagePath[2] = new Vector3(transform.position.x + 5 , transform.position.y - 5, transform.position.z + 0.5f);

        moveSetting.Add("path", damagePath);

        //在path結束時移除此字體物件
        moveSetting.Add("oncomplete", "destoryDamageFont");
    }

    void destoryDamageFont(){
        Destroy(this.gameObject);
    }
}
