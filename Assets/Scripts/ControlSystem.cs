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
        [Header("���ʳt��"), Range(0, 10)]
        public float MoveSpeed = 2.0f;
        [Header("�����"), Tooltip("�o�O���⥪�䪺��m����")]
        public float LimitLeft = -9.5f;
        [Header("�k���"), Tooltip("�o�O����k�䪺��m����")]
        public float LimitRight = 9.5f;
        [SerializeField] Text �H���y�� = null;

        Vector3 InitialPosition;
        
        // Initialize
        private void Awake() // �C���}�l�ɷ|����1��
        {
            // �]�w�Ө��⪺��l�y��
            InitialPosition = new Vector3(0f, -7.25f, 0f);
            transform.position = InitialPosition;

        }

        // Game logic
        private void Update()
        // ��s�ƥ�: ��1������ 60 FPS
        // �i�H�������a����J�欰: ��L, �ƹ�, �n��, Ĳ��, XR���
        {
            Move();
        }

        /// <summary>
        /// ���ʤ�k: �������a����J�ñ���Ⲿ��, �H�νd�򭭨�
        /// </summary>
        private void Move()
        {
            float MoveX = Input.GetAxis("Horizontal"); // ���a��J����������, ex: a, d, ��, ��
            transform.Translate(MoveX * Time.deltaTime * MoveSpeed, 0, 0); // �����󲾰�(x, y, z), �bupdate�̭���ܨC��frame������1��
            Vector3 Position = transform.position;

            Position.x = Mathf.Clamp(Position.x, LimitLeft, LimitRight); // ���ʽd��

            transform.position = Position;
            �H���y��.text = "Position = " + Position.ToString("N3");
        }
    }
}