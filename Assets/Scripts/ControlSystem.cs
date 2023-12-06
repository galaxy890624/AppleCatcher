/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;
using UnityEngine.UI;

namespace galaxy890624
{
    /// <summary>
    /// 
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        [Header("移動速度"), Range(0, 10)]
        public float MoveSpeed = 2.0f;
        [Header("左邊界"), Tooltip("這是角色左邊的位置限制")]
        public float LimitLeft = -9.5f;
        [Header("右邊界"), Tooltip("這是角色右邊的位置限制")]
        public float LimitRight = 9.5f;
        [SerializeField] Text 人物座標 = null;

        Vector3 InitialPosition;

        private void Awake() // 遊戲開始時會執行1次
        {
            // 設定該角色的初始座標
            InitialPosition = new Vector3(0f, -7.25f, 0f);
            transform.position = InitialPosition;

        }

        private void Update()
        // 更新事件: 約1秒後執行 60 FPS
        // 可以偵測玩家的輸入行為: 鍵盤, 滑鼠, 搖桿, 觸控, XR控制器
        {
            Move();
        }

        /// <summary>
        /// 移動方法: 偵測玩家的輸入並控制角色移動, 以及範圍限制
        /// </summary>
        private void Move()
        {
            float MoveX = Input.GetAxis("Horizontal"); // 玩家輸入的水平按鍵, ex: a, d, ←, →
            transform.Translate(MoveX * Time.deltaTime * MoveSpeed, 0, 0); // 讓物件移動(x, y, z), 在update裡面表示每個frame都執行1次
            Vector3 Position = transform.position;

            Position.x = Mathf.Clamp(Position.x, LimitLeft, LimitRight); // 移動範圍

            transform.position = Position;
            人物座標.text = "Position = " + Position.ToString("N3");
        }
    }
}