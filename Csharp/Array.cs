using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[5]; // ũ�Ⱑ 5�� int�� �迭 ����
            string[] array2 = new string[3]; // ũ�Ⱑ 3�� int�� �迭 ����
            int num = 0;

            array1[0] = 1;
            array1[1] = 2;
            array1[2] = 3;

            num = array1[0];

            Console.WriteLine($"{array1[0]}");
            Console.WriteLine();
               /*********************************************************************************/

            int[] itemPrices = { 100, 200, 300, 400, 500 };
            int totalPrice = 0;

            for( int i = 0; i < itemPrices.Length; i++)
            {
                totalPrice += itemPrices[i];
            }

            Console.WriteLine($"{totalPrice}");
            Console.WriteLine();

            /*********************************************************************************/

            // �ɷ�ġ�� �������� ����
            Random rand = new Random();
            int[] playerStats = new int[4]; // ũ�Ⱑ 4�� int�� �迭 ����
            for (int i = 0; i < playerStats.Length; i++)
            {
                playerStats[i] = rand.Next(1, 11);  // 1�̻� 10������ ���ڸ� �������� �Ҵ� (11�� ����x)
            }

            Console.WriteLine("�÷��̾��� ���ݷ�: " + playerStats[0]);
            Console.WriteLine("�÷��̾��� ����: " + playerStats[1]);
            Console.WriteLine("�÷��̾��� ü  ��: " + playerStats[2]);
            Console.WriteLine("�÷��̾��� ���ǵ�: " + playerStats[3]);
            
            /*********************************************************************************/
            
            int[] scores = new int[5];

            for (int i= 0; i< scores.Length; i++)
            {
                Console.Write("�л� " + (i+1) + " �� ������ �Է��ϼ��� : ");
                scores[i] = int.Parse(Console.ReadLine()); // �Է��� int ������ ��ȯ �� �迭 i�� �Ҵ�
            }

            int sum = 0;
            for(int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }

            double average = (double)sum / scores.Length;
            Console.WriteLine("���� ����� " + average + " �Դϴ�.");

            /*********************************************************************************/
            Random random = new Random(); // ���� ��ü ����
            int[] numbers = new int[3]; // 3���� ������ ���ڸ� ������ �迭

            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10); // 1�̻� 9������ ����
            }


            int attempt = 0;    //�õ� Ƚ��

            while(true)
            {
                Console.WriteLine($"3���� ���ڸ� �Է��ϼ��� (1~9): ");
                int[] guess = new int[3];

                for(int i = 0; i <guess.Length; i++)
                {
                    // 3���� ���ڸ� ����ڿ��� �Է¹ް� int������ ��ȯ
                    guess[i] = int.Parse(Console.ReadLine());   
                }

                int correct = 0;

                for(int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j<guess.Length; j++)
                    {
                        if (numbers[i] == guess[j])
                        {
                            correct++;
                            break;
                        }
                    }
                }

                attempt++;
                Console.WriteLine($"�õ� #" + attempt + " : " + correct + " ���� ���ڸ� ���߼̽��ϴ�.");
                
                if (correct == 3)
                {
                    Console.WriteLine($"�����մϴ�! ��� ���ڸ� ���߼̽��ϴ�.");
                    
                    break;
                }
            }

            /*********************************************************************************/
            int[,] map = new int[5,5]
            {
                {1,1,1,1,1},
                {1,0,0,0,1},
                {1,0,1,0,1},
                {1,0,0,0,1},
                {1,1,1,1,1},
            };

            for (int i = 0; i<5 ; i++)
            {
                for(int j = 0 ; j<5; j++)
                {
                    if (map[i,j] == 1)
                    {
                        Console.Write("��");
                        
                    }
                    else
                    {
                        Console.Write("��");
                        
                    }
                    Console.WriteLine($"");  
                }
            }

        }
    }
}