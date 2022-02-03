using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
//１秒間に６０回動くupdateのその直前に動くのが以下
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(prefab);
            obj.transform.parent = transform;
            obj.transform.localPosition = Vector3.zero;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //ray.directionでvector3（つまりベクトル）になる。
            //クリックした場所によってベクトルの大きさが異なるので速さが異なる。
            //それをどの方向でも同じ大きさにするためにnormalizedで全ての大きさを１にする。
            Vector3 dir = ray.direction.normalized;
            //velocityは速度。プロパティなので代入。
            obj.GetComponent<Rigidbody>().velocity = dir * 100.0f;
            //obj.GetComponent<Rigidbody>().AddForce(dir * 100.0f);
            //obj.GetComponent<Rigidbody>().AddForce(dir * 100.0f, ForceMode.Impulse);
        }

    }
}
