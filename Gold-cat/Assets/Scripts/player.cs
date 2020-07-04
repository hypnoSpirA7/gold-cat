using UnityEngine;

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
    [Header("速度"), Tooltip("腳色的移動速度"), Range(10, 1500)]
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
    [Header("腳色死亡"),Tooltip("True 死亡,False 未死亡")]
    public bool character_dead;

    #endregion

    #region 方法區域
    // C# 括號服後都是成對出現的:() [] {} "" ''
    //摘要:方法說明
    //在方法後面加三條/
    // 自訂方法 - 不會執行的,需要呼叫
    // API - 功能倉庫
    // 輸出功能 print("字串")

    /// <summary>
    /// 腳色跳躍功能:跳躍動畫,播放音效
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }
    /// <summary>
    /// 腳色滑行功能:滑行動畫,撥放音效,縮小碰撞範圍
    /// </summary>
    private void Slide()
    {
        print("滑行");
    }
    /// <summary>
    /// 碰撞障礙時受傷:扣血
    /// </summary>
    private void Hit()
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
    }
    #endregion
}
