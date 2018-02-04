using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = new int[5];

        // 配列の各要素に値を代入する
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        Debug.Log("ここから逆");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[4 - i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        // 10回実行
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + "回目");
            boss.Magic();
        }
        // 11回目
        Debug.Log("11回目");
        boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Boss
{
    private int hp = 100;          // 体力
    private int mp = 53;          // 体力ではない方
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 攻撃用の関数ではない方
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}
