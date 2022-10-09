using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Rigidbody rd;

    public int score = 0;

    public Text scoreText;

    public GameObject winText;

    // Start is called before the first frame update
    // Start 方法 Update 方法 函数 = 命令   
    void Start()
    {
        //Debug.Log("游戏开始了");
        //打印 输出 显示
        //日志 //赋值
        //rd = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("游戏正在运行");
        //(x,y,z) (1,0,0)
        // Vector3.right left forward back
        // (2,0,0)
        //rd.AddForce( new Vector3(10,0,0) );

        float h = Input.GetAxis("Horizontal");//-1 1
        float v = Input.GetAxis("Vertical");// ws 
        //Debug.Log(h);  (1,2,3) * 2 = (2,4,6)
        rd.AddForce(new Vector3(h, 0, v) * 1 );
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("发生碰撞了 OnCollisionEnter");


        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
        }

    }
    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("发生碰撞了 OnCollisionExit");
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("发生碰撞了 OnCollisionStay");
    //}

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter"+other.tag);

        if (other.tag == "Food")
        {
            Destroy(other.gameObject);

            //++自增运算符
            score++;

            scoreText.text = "分数：" + score ;

            if(score == 12)
            {
                winText.SetActive(true);//true false
            }
        }


    }
    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("OnTriggerExit" + other.tag);
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("OnTriggerStay" + other.tag);
    //}
}
