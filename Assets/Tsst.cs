using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int magicpower= 53;   //���͏����l53
    private int mAtk = 5; //���@����5

    //�U���p�̊֐�
    public void Magic()
    {
        if (magicpower > 5)
        {
            //���@�g�p��̕ϐ�a��p�ӁB�g�p����x�ɖ��͂�5����
            int a = magicpower -= mAtk;

            //�����@�g�p���mp�\��
            Debug.Log("���@�U���������B�c��MP��" + a);
        }
        else
        {
            //���͂�����Ȃ��Ƃ�
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }
}
public class Tsst : MonoBehaviour
{
      // Start is called before the first frame update
    void Start()
    {
        //�z���������
        int[] array = { 50, 10, 30, 80, 40 };

        //�z������Ԃɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array [i]);
        }
        
        //�z����t���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lasuboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
        lasuboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}