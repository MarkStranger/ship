using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//public enum StudentsAge : int
//{
//    AleksandrK = 40,
//    AlexR = 31,
//    Veron = 14
//}


public enum AffairsOfTheWeeks : int
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public enum Moovet : int
{
    Stop,
    Moove
}



public class TestMoove : MonoBehaviour
{

    
    [SerializeField] private float speed = 20;
    private float direction;
    

    AffairsOfTheWeeks affairsOfTheWeeks;
    Moovet moovet;

    public int result;



   

    void Update()
    {
        if (moovet == Moovet.Moove)
        {
            if (((transform.position.x >= -22f) && (direction == -1f)) || ((transform.position.x <= 22f) && (direction == 1f)))

            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
           
        }



    }

    public void MoveRight()
    {
        moovet = Moovet.Moove;
        int a = (int)moovet;
        direction = 1f;
       
    }
    public void MoveLeft()
    {
        moovet = Moovet.Moove;
        int a = (int)moovet;
        direction = -1f;
       
    }
    public void StopMove()
    {
        moovet = Moovet.Stop;
      
    }

    public void Poned()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Monday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : �������� �������");

    }

    public void Vtorn()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Tuesday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : �������� �����");

    }

    public void Srerda()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Wednesday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : �������� c�������");

    }

    public void Chetverg()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Thursday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : �������� �������");

    }

    public void Pyatniza()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Friday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : �������� ����� Unity");

    }
    public void Subbota()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Saturday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : ��������1");

    }
    public void Voskr()
    {


        affairsOfTheWeeks = AffairsOfTheWeeks.Sunday;// ��������� ����������
        int a = (int)affairsOfTheWeeks;// �������� ���������
        result = a;
        //print(affairsOfTheWeeks);
        //print("���� ������ " + a + " : ��������2");

    }
    public void Chekk()
    {


        if(result == 1)
        {
            print("�������� �������");
        }
        else if (result == 2)
        {
            print("�������� �����");
        }
        else if (result == 3)
        {
            print("�������� c�������");
        }
        else if (result == 4)
        {
            print("�������� �������");
        }
        else if (result == 5)
        {
            print("�������� ����� Unity");
        }
        else if (result == 6)
        {
            print("�������� ���������");
        }
        else if (result == 7)
        {
            print("��������");

        }
        else 
        {
            print("�������� �������");
        }
    }


}
