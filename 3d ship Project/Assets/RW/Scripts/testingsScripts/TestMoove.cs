using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum StudentsAge : int
{
    AleksandrK = 40,
    AlexR = 31,
    Veron = 14
}






public class TestMoove : MonoBehaviour
{

    //����������_������� enum ��� : ���
    //{
    //    ���1 = ��������1,
    //    ���2 = ��������2,
    //}
    StudentsAge studentsAge;
   



    void Start()
    {
        studentsAge = StudentsAge.AlexR;// ��������� ����������
        int a = (int)studentsAge;// �������� ���������
        print(studentsAge);
        print(a);
        if(studentsAge == StudentsAge.Veron)// �������� ���������
        {

        }

    }

}
