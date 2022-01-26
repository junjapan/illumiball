using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //構造体の初期化
        Vector3 v1 = new Vector3();
        Debug.Log(v1);
        Vector3 v2 = new Vector3(2,3,4);
        Debug.Log(v2);
        //値の更新
        v1.x = 10f;
        v1.y = 20f;
        v1.z = 30f;
        Debug.Log(v1);
        //Vector3同士の加算、減算
        v1 = new Vector3(1, 2, 3);
        v2 = new Vector3(5, 6, 7);
        Vector3 v3 = v1 + v2;
        Debug.Log(v3);

        Vector3 v4 = v2 - v1;
        Debug.Log(v4);

        //vector3と値の乗算、除算
        v1 = new Vector3(2, 4, 6);
        v2 = v1 * 2;
        Debug.Log(v2);
        v3 = 2 * v1;
        Debug.Log(v3);

        v4 = v1 / 2;
        Debug.Log(v4);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
