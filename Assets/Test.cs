using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    // 攻撃(通常)
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 攻撃(魔法)
    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
    }

    // 防御
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

}


public class Test : MonoBehaviour {

     // Use this for initialization
    void Start () {

        Kadai1();

        Kadai2();
    }

    void Kadai1()
    {
        int[] array = { 0, 10, 20, 30, 40};

        // 昇順に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 降順に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[5 - 1 - i]);
        }
    }

    void Kadai2()
    {
        Boss lastboss = new global::Boss();

        // 魔法を10回使う
        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        // 魔法はもう使えないことを確認
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
