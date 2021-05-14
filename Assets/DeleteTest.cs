using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTest : MonoBehaviour
{
    // カメラに写っていないときにオブジェクトを削除
    void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);
    }

}
