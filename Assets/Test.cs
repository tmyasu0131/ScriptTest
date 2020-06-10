using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 魔力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        this.mp -= 5;
        if (mp >= 0){
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {

        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

        // 配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        //配列の各要素の値を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        Debug.Log("ここから発展課題");
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す
        lastboss.Magic();
        for (int i = 1; i <= 10; i++)
        {
            // 魔法用の関数を呼び出す
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}