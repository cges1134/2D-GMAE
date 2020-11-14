using UnityEngine;

public class Car : MonoBehaviour
{
    // 單行註解：紀錄、說明、開發者名稱..

    // 資料 = C# 欄位 (Field)
    // 語法：
    // 類型 名稱 (指定 值)；

    //四大基本類型:整 數：int 浮點數：float 字串：string 布林值：bool

    //修飾詞-定義資料的權限
    //私人 private (預設值)  -不顯示在屬性面板
    //公開 public            -顯示在屬性面板
    [Header ("這是汽車的屬性面板") ]
    [Tooltip("這是汽車的CC數")]
    public int cc = 2000;
    [Tooltip ("這是汽車的重量")]
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


        }