using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //自プログラムはプレハブに付いていて、cubuGeneratorにて任意のタイミングで生成される。
    //つまりHierarchy画面にいないので以下はプライベートフィールドになる。
    //findで見つけて操作することも出来るがその場合はコストが大きい。
    private GameManager gm;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            gm.SetScore(gm.GetScore() + 1);
            Destroy(gameObject, 0.1f);
        }
        if (coll.gameObject.tag == "Floor")
        {
            gm.SetMsg("GameOver");
        }
    }
    public void SetGameManager(GameManager gm)
    {
        this.gm = gm;
    }
}
