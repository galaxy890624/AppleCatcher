using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // [SerializeField] UnityEvent ���s�I������ = null;

    public void �}�l()
    {
        Debug.Log("�}�l");
        SceneManager.LoadScene("GamePlay");
    }

    public void �ɯ�()
    {
        Debug.Log("�ɯ�");
        SceneManager.LoadScene("TechnologyTree");

    }
    public void �ﶵ()
    {
        Debug.Log("�ﶵ");
    }
    public void ���}()
    {
        Debug.Log("���}");
        Application.Quit(); // �b Unity ���I���}�C���O���|���@��, �ݭn�o�GPC�Ϊ̤��, �D��������
    }
    public void ��^Menu()
    {
        Debug.Log("��^Menu");
        SceneManager.LoadScene("Menu");
    }
}