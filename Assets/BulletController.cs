using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //OnBecameInvisibleは、カメラのレンダリング範囲から外れたらという意味
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
