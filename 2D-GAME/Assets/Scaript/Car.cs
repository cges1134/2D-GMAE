using UnityEngine;

public class Car : MonoBehaviour
{
    #region 練習語法
    // 單行註解：紀錄、說明、開發者名稱..

    // 資料 = C# 欄位 (Field)
    // 語法：
    // 類型 名稱 (指定 值)；

    //四大基本類型:整 數：int 浮點數：float 字串：string 布林值：bool

    //修飾詞-定義資料的權限
    //私人 private (預設值)  -不顯示在屬性面板
    //公開 public            -顯示在屬性面板
    [Header("這是汽車的屬性面板")]
    [Tooltip("這是汽車的CC數")]
    [Range(1000, 2000)]
    public int cc = 2000;
    [Tooltip("這是汽車的重量")]
    public float weight = 1500.5f;  //小數點號面要加f或F 
    [Tooltip("這是汽車的品牌")]
    public string brand = "BMW";           //文字必須加雙引號
    [Tooltip("汽車是否有天窗勾起來是有不勾是沒有")]
    public bool haveWindow = true;           //是 true 否 false

    //其他類型 顏色、座標 2~4 個 、遊戲物件、元件 (屬性面板上粗體字 Rigidbofy 2D collider 2D...)

    //顏色
    public Color red = Color.red;
    public Color myColor = new Color(0.2f, 0, 23);      //新的顏色();
    //2維~4維 座標
    //2維     
    public Vector2 pos0 = Vector2.zero;
    public Vector2 pos1 = Vector2.one;
    public Vector2 pos2 = new Vector2(2, 3);
    //3維
    public Vector3 posV3 = Vector3.one;
    //4維
    public Vector4 posV4 = Vector4.one;

    //遊戲元件與元件 不需要 指定 值
    public GameObject obj;                  //可以存放白線物件與預製物
    public Transform tra;
    public SpriteRenderer sr;
    #endregion
    #region 事件
    // 事件：開始 - 播放遊戲時執行一次
    private void Start()
    {
        // 事件：開始 - 播放遊戲時執行一次
        print("Hi~你在嗎?");

        Shoot(1, 500);
        Shoot(2, 600);
        Shoot(3);
        
    }
    //事件:持續內容 比如-鍵盤、滑鼠 一秒大約更新60FPS
    private void Update()
    {
        print("在開車");
        Drive(0.01f);
    }
    //方法 
    //語法
    //定義程式區塊的語法
    //修飾詞 傳回類型 名稱 (參數) [程式]
    //參數語法:(參數類型+空白鍵+參數名稱())
    // ※ 有預設值的參數要放在最右邊
    //無傳回 void 僅會傳出語法
    //方法需要被呼叫才會回應
    private void Drive(float 速度)
    {
        print("別吵我");
        transform.Translate(速度, 0, 0);
    }
    //摘要不是必要但很重要
    /// <summary>
    /// 發射弓箭的功能
    /// </summary>
    /// <param name="count">弓箭數量</param>
    /// <param name="speed">弓箭速度預設為300</param>
    private void Shoot(int count, int speed = 300)
    {
        print("弓箭數量：" + count);
        print("弓箭速度：" + speed);
    }
    }

#endregion}