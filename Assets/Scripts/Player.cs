using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{


    

    // 定义刚体属性   
    public Rigidbody rd;
    public int score = 0;

    public Text scoreText;

    public GameObject winText;

    private void Awake()
    {

    }

    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("game start play");
        // 获取刚体组件对象
        rd = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("game is playing");

        // 添加一个右边的力
        // rd.AddForce(Vector3.right);

        // 创建一个自定义的向量力
        //Vector3 power = new Vector3(2, 0, 0);
        //rd.AddForce(power);

        // 获取水平按键结果；[-1,1]
        float h = Input.GetAxis("Horizontal");
        //rd.AddForce(new Vector3(h, 0, 0));
        // 获取前后按键结果：[-1,1]
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v));
    }



    /* *
     * 触发检测ss
     */
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Player Collision , target tag = " + other.tag);
        if (other.tag == "food") {
            Destroy(other.gameObject);
            // 每次碰撞+1分
            score++;

            scoreText.text = "分数：" + score;

            if (score == 1) {
                winText.SetActive(true);
            }
        }   
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }


    ///**
    // * 发生物体碰撞
    // * Collision collision 碰撞到的对象信息
    // */
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // collision.collider.tag == "food"  // 通过碰撞器判断
    //    // 根据物体标签判断是否碰到需要销毁的物体，并做销毁
    //    if (collision.gameObject.tag == "food")
    //    {
    //        Destroy(collision.gameObject);
    //    }

    //}

    ///**
    // * 物体碰撞结束
    // */
    //private void OnCollisionExit(Collision collision)
    //{

    //}

    ///**
    // * 物体碰撞中
    // */
    //private void OnCollisionStay(Collision collision)
    //{

    //}
}
    