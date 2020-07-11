﻿using UnityEngine;

public class player : MonoBehaviour
{
    // 單行註解

    /* 多
     * 行
     * 註
     * 解
     * */
    // 區域
    #region 欄位區域

    // 命名規則
    // 1. 用有意義的名稱
    // 2. 不要使用數字開頭
    // 3. 不要使用特殊符號 含空格
    // 4. 可以使用中文

    // 欄位語法
    // 修飾詞 類型 欄位名稱 = 值;
    // 沒有 = 個
    // 整數 浮點數 預設值0
    // 字串 預設值""
    // 布林值 fales

    // 私人 private - 僅限於此類別使用 | 不會顯示 - 預設值
    // 公開 public - 所有類別皆可使用 | 會顯示

    // 欄位屬性 [屬性名稱()]
    // 標題 Header
    // 提示 Tooltip
    // 範圍 Range
    [Header("血量"), Tooltip("腳色血量"), Range(0, 100)]
    public float health = 100;
    [Header("金幣數量"), Tooltip("儲存腳色金幣數量")]
    public int coin;
    [Header("音效")]
    public AudioClip coin_sound;
    [Header("速度"), Tooltip("腳色的移動速度"), Range(1, 1500)]
    public float movement_speed = 50;
    [Header("音效")]
    public AudioClip jump_sound;
    [Header("跳躍高度"), Tooltip("腳色的跳躍高度")]
    public float Jump_height = 100;
    [Header("跳躍移動速度"), Tooltip("腳色的跳躍速度")]
    public float Jump_movement;
    [Header("跳躍移動時間"), Tooltip("腳色的跳躍時間")]
    public float Jump_time;
    [Header("音效")]
    public AudioClip slide_sound;
    [Header("滑行速度"), Tooltip("腳色的滑行速度")]
    public float slide_speed;
    [Header("滑行持續時間"), Tooltip("腳色的滑行時間")]
    public float slide_time;
    [Header("腳色死亡"), Tooltip("True 死亡,False 未死亡")]
    public bool character_dead;
    [Header("動畫控制器")]
    public Animator ani;
    [Header("膠囊碰撞器")]
    public CapsuleCollider2D cc2d;
    [Header("剛體")]
    public Rigidbody2D rig;
    /// <summary>
    /// 是否在地板上
    /// </summary>
    public bool isGround;
    #endregion

    #region 方法區域
    // C# 括號服後都是成對出現的:() [] {} "" ''
    //摘要:方法說明
    //在方法後面加三條/
    // 自訂方法 - 不會執行的,需要呼叫
    // API - 功能倉庫
    // 輸出功能 print("字串")

    private void Move()
    {
        // 如果 剛體.加速度.大小 小於5
        if (rig.velocity.magnitude < 5)
        {
            // 剛體.添加推力 二為向量
            rig.AddForce(new Vector2(movement_speed, 0));
        }
        
    }

    /// <summary>
    /// 腳色跳躍功能:跳躍動畫,播放音效
    /// </summary>
    private void Jump()
    {
        bool jump = Input.GetKey(KeyCode.Space);

        // 顛倒速算子
        // 作用:將布林值變成相反
        // !true ----- false

        // 動畫控制器代號
        ani.SetBool("jump", jump);

        // 搬家 Alt+上,下
        // 格式化 Ctrl+K,D

        // 如果在地板上
        if (isGround)
        {
            if (jump)
            {
                isGround = false;                            // 不在地板上
                rig.AddForce(new Vector2(0, Jump_height));   // 剛體 添加推力(二為向量)
            }
        }

    }
    /// <summary>
    /// 腳色滑行功能:滑行動畫,撥放音效,縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        bool slide = Input.GetKey(KeyCode.X);

        // 動畫控制器代號
        ani.SetBool("slide", slide);

        if (slide)  // 如果按下 X 縮小
        {
            cc2d.offset = new Vector2(-0.19f, -1f);  // 位移
            cc2d.size = new Vector2(2.4f, 2f);       // 尺寸
        }
        // 否則恢復
        else
        {
            cc2d.offset = new Vector2(-0.19f, -0.25f);  // 位移
            cc2d.size = new Vector2(2.4f, 4f);       // 尺寸
        }
    }
    /// <summary>
    /// 碰撞障礙時受傷:扣血
    /// </summary>
    private void Hurt()
    {

    }
    /// <summary>
    /// 吃金幣:金幣數量增加,介面更新,金幣音效
    /// </summary>
    private void EatCoin()
    {

    }
    /// <summary>
    /// 死亡:動畫,遊戲結束
    /// </summary>
    private void Dead()
    {

    }
    #endregion

    #region 事件區域
    // 開始 Start
    // 撥放遊戲時執行一次
    // 初始化:
    private void Start()
    {
        // 呼叫跳耀方法
        Jump();
    }
    // 更新 Update
    // 播放遊戲後一秒直行約60次 - 60FPS
    // 移動,監聽玩家鍵盤,滑鼠與觸控
    private void Update()
    {
        Slide();
        Jump();
        Move();
    }

    /// <summary>
    /// 固定更新事件:一秒固定執行50次,只要有剛體就寫在這
    /// </summary>
    private void FixedUpdate()
    {
        Jump();
        Move();
    }
    /// <summary>
    /// 碰撞事件:碰到物件開始執行一次
    /// </summary>
    /// <param name="collision">碰到物件的碰撞資訊</param>
    private void OnCollisionEnter2D(Collision2D collision)

    {
        // 如果 碰到物件 的名稱=地板
        if (collision.gameObject.name == "空中地板")
        {
            // 是否在地上 = 是
            isGround = true;
        }
    }
    #endregion
}
