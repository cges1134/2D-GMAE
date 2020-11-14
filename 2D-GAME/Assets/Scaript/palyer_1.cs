using UnityEngine;

public class palyer_1 : MonoBehaviour
{
    #region 玩家
    [Tooltip("移動速度"),Range(0, 1000)]
    public float speed = 10.5f;
    [Tooltip("跳躍高度"),Range(0, 3000)]
    public int Jump = 100;
    [Header("是否在地板上"),Tooltip("用來儲存玩家是否站在地板上")]
    public bool isGrounded = false;
    [Header("分數")]
    [Header("子彈"), Tooltip("存放要生成的子彈預製物")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("子彈要生成的起始位置")]
    public Transform point;
    [Header("子彈速度"), Range(0, 5000)]
    public int speedBullet = 800;
    [Header("開槍音效")]
    public AudioClip soundFire;
    [Header("生命數量"), Range(0, 10)]


    private int live = 3;
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
    private int score;
    #endregion
  

}