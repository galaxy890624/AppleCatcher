using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    [Header("���G����")] // ������ Lv 0 �ƨ� Lv 7
    public GameObject[] FruitLevel = null;
    Vector3 InitialPosition;
    [Header("�����"), Tooltip("�o�O���G�X�{�̥��䪺��m����")]
    public float LimitLeft = -9.5f;
    [Header("�k���"), Tooltip("�o�O���G�X�{�̥k�䪺��m����")]
    public float LimitRight = 9.5f;
    int random = 0;
    float SpawnTime = 0f;
    // initialize
    private void OnEnable()
    {
        random = UnityEngine.Random.Range(0, 3); // �H���ͦ� Lv0 ~ Lv3 �����G
        for (int i = 0; i < FruitLevel.Length; i++) // �}�l�ɱN�Ҧ���������
        {
            FruitLevel[i].SetActive(false);
            //print("<color=#0f7fff>�ڦ�<color=#ff00ff>��������</color>��</color>");
        }
        InitialPosition = new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f);
        transform.position = InitialPosition;
        FruitLevel[random].SetActive(true); // ��n�ͦ������G���󥴶}
        //print("<color=#0f7fff>�ڦ�<color=#ff00ff>���}����</color>��</color>");
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            this.gameObject.SetActive(false); // �R���ۤv���C������
            Destroy(this.gameObject);
            //print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Collider2D</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
        else if (other.tag == "Ground")
        {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
            //print("<color=#0f7fff>�ڦ��q<color=#ff00ff>Collider2D</color>�i��<color=#ff0000>OnDisable()</color>��</color>");
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if(Time.time > SpawnTime)
        {
            print($"<color=#ff00ff>SpawnTime = <color=#00ff00>{SpawnTime}</color>,�ڭn�ͦ����G�o</color>");
            // Instantiate(this.gameObject, new Vector3(UnityEngine.Random.Range(LimitLeft, LimitRight), 7f, 0f), Quaternion.identity);
            SpawnTime += 1.0f;
        }
        
    }
    // decommit
    private void OnDisable()
    {
        OnEnable();
    }
}
