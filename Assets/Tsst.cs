using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int magicpower= 53;   //魔力初期値53
    private int mAtk = 5; //魔法消費5

    //攻撃用の関数
    public void Magic()
    {
        if (magicpower > 5)
        {
            //魔法使用後の変数aを用意。使用する度に魔力が5減る
            int a = magicpower -= mAtk;

            //魔魔法使用後のmp表示
            Debug.Log("魔法攻撃をした。残りMPは" + a);
        }
        else
        {
            //魔力が足りないとき
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
}
public class Tsst : MonoBehaviour
{
      // Start is called before the first frame update
    void Start()
    {
        //配列を初期化
        int[] array = { 50, 10, 30, 80, 40 };

        //配列を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array [i]);
        }
        
        //配列を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lasuboss = new Boss();

        //攻撃用の関数を呼び出す
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}