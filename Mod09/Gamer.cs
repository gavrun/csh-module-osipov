using System;

namespace ClasswithEvent
{

	// ������� ����� "��������� �����".
	class Dice
	{
		Random r;
       
		//� ������������ ������ ��������� ���������� r, ������������ ��������� �������� Random
		public Dice()
		{
			r=new Random();
		}

		//������� �����, � ������� ����� ��������������� ������.
		public int random()
		{
			//�������� ����� �� 1 �� 6.
			int res = r.Next(6)+1;
			return res;
		}
	}

    class Gamer
    {
        string Name;
        Dice seans; // ���������� - ���������

        public Gamer(string name/*, Dice si*/)//��� ��������� ���� ����� �������
        {
            Name = name;
           // seans = si;// ��� ���������
            seans = new Dice(); // ��� ������ ��  ������ ��� ����������
        }

        public int SeansGame()
        {
            return seans.random();
        }

        //public int SeansGame(Dice ig) // �����������
        //{
           
        //    return ig.random();
        //}

        public override string ToString()
        {
            return Name;
        }
    }


	class Program
	{
		static void Main(string[] args)
		{		
		
	    //������� ��������� brosok ������ 
            Dice roll = new Dice(); // ��� ���������

          
         //   Gamer g1 = new Gamer("Niko",roll); // ��� ���������
            Gamer g1 = new Gamer("Niko");           // ��� ����������
            for (int i = 1; i <= 6; i++)
            Console.WriteLine("������ ���������� ����� {0} ��� ������ {1}", g1.SeansGame(), g1.ToString());
          //for (int  i = 1; i<=5; i++)
          //  Console.WriteLine("������ ���������� ����� {0} ��� ������ {1}", g1.SeansGame(brosok), g1.ToString());

		}
	}
}
