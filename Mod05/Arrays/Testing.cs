using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Testing
    {
        /// <summary>
        /// ������������ ����������� ��������
        /// </summary>
        public void TestDeclaration()
        {
            //����������� ��� ���������� ������� A,B,C
            int[] A = new int[5], B = new int[5], C = new int[5];
            Arrs.CreateOneDimAr(A);
            Arrs.CreateOneDimAr(B);
            for (int i = 0; i < 5; i++)
                C[i] = A[i] + B[i];
            //���������� ������� � ����� ��������������
            int[] x ={ 5, 5, 6, 6, 7, 7 };
            //���������� �������� � ���������� ��������������
            int[] u, v;
            u = new int[3];
            for (int i = 0; i < 3; i++) u[i] = i + 1;
            // v = {1,2,3}; //������������ ������������ ������� �����������
            v = new int[4];
            v = u; //���������� ������������
            Arrs.PrintAr1("A", A); Arrs.PrintAr1("B", B);
            Arrs.PrintAr1("C", C); Arrs.PrintAr1("X", x);
            Arrs.PrintAr1("U", u); Arrs.PrintAr1("V", v);
        }
        /// <summary>
        /// ���������� ������������� ������� A1
        /// </summary>
        public void TestDynAr()
        {
            
            Console.WriteLine("������� ����� ��������� ������� A1");
            int size = int.Parse(Console.ReadLine());
            int[] A1 = new int[size];
            Arrs.CreateOneDimAr(A1);
            Arrs.PrintAr1("A1", A1);
        }//TestDynAr

        /// <summary>
        /// ���������� ���������� ������� � ��������������
        /// </summary>
        public void TestMultiArr()
        {
            int[,] matrix = {
										{1,2},
										{3,4}
							};
            Arrs.PrintAr2("matrix", matrix);
        }//TestMultiArr

        /// <summary>
        /// ������������ ��������� ������ 
        /// </summary>
        public void TestMultiMatr()
        {
            int n1, m1, n2, m2, n3, m3;
            Arrs.GetSizes("MatrA", out n1, out m1);
            Arrs.GetSizes("MatrB", out n2, out m2);
            Arrs.GetSizes("MatrC", out n3, out m3);
            int[,] MatrA = new int[n1, m1], MatrB = new int[n2, m2];
            int[,] MatrC = new int[n3, m3];
            Arrs.CreateTwoDimAr(MatrA); Arrs.CreateTwoDimAr(MatrB);
            Arrs.MultMatr(MatrA, MatrB, MatrC);
            Arrs.PrintAr2("MatrA", MatrA); Arrs.PrintAr2("MatrB", MatrB);
            Arrs.PrintAr2("MatrC", MatrC);
        }//TestMultiMatr
        public void TestJuggerArrs()
        {
            //������ �������� - ���������� ������
            //���������� � �������������
            int[][] jagger = new int[3][]
							{
								new int[] {5,7,9,11},
								new int[] {2,8},
								new int[] {6,12,4}
							};
            int[][,] jagger1 = new int[3][,]
							{
								new int[4,2],
								new int[2,17],
								new int[3,2]
							};
            int[][] jagger2 =
 							{
								new int[4],
								new int[2],
								new int[3]
							};
        }
        /// <summary>
        /// ������ �������� -"���� � ����"
        /// </summary>
        public void GenTree()
        {            
            int Fcount = 3;
            string[] Fathers = new string[Fcount];
            Fathers[0] = "�������"; Fathers[1] = "������"; Fathers[2] = "����";
            string[][] Children = new string[Fcount][];
            Children[0] = new string[] { "�����", "�����" };
            Children[1] = new string[] { "������", "���������", "���", "�������" };
            Children[2] = new string[] { "�����", "�����", "�������" };
            Arrs.PrintAr3(Fathers, Children);

        }


    }
}
