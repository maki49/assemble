using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[RequireComponent(typeof(Rigidbody))]
public class assemble : MonoBehaviour
{
    public GameObject goal;//把目标拖进来
    public Rigidbody rb;
    private Transform selftrans;//自身状态
    private Transform goaltrans;//目标状态
    public float v;//设定速度
                   // Use this for initialization
    void Start()
    {
        //rb = gameObject.GetComponent<Rigidbody>();//获取当前物体的实体
        selftrans = gameObject.GetComponent<Transform>();//获取当前物体位置
        goaltrans = goal.GetComponent<Transform>();//获取初始目标位置
    }

    // Update is called once per frame
    void Update()
    {

        float xdis, ydis, zdis, dis;
        float dx, dy, dz;
        xdis = goaltrans.position.x - selftrans.position.x;
        ydis = goaltrans.position.y - selftrans.position.y;
        zdis = goaltrans.position.z - selftrans.position.z;
        dis = Vector3.Distance(goaltrans.position, selftrans.position);
        dx = v * xdis / dis;
        dy = v * ydis / dis;
        dz = v * zdis / dis;
        //更新当前位置
        selftrans.position = selftrans.position + new Vector3(dx, dy, dz);
        gameObject.transform.position = selftrans.position;

    }
}