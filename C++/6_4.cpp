/* 배열과 선택 정렬 */

#include <iostream>

using namespace std;

void printArray(const int array[], const int length)
{
    for (int index = 0; index < length; ++index)
        cout << array[index] << " ";
    cout << endl;
}

int main()
{
    const int length = 5;
    int array[length] = { 3, 5, 2, 1, 4};

    for (int i = 0; i < length-1; i ++)
    {
        for (int y = i + 1; y < length; y++)
        {
            if (array[i] > array[y])
            {
                int min_number = array[y];
                array[y] = array[i];
                array[i] = min_number;
            }
        }
    }

    printArray(array, length);
}


// 선택정렬 스스로 구현해서 너무 기분좋다...