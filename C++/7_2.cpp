/* ���� ���� �μ� ����. Call by value */
#include <iostream>

using namespace std;

void doSomething(int y)
{
    cout << "�Լ����� �ҷ����� �� " << y << " " << &y << endl;
}

int main()
{
    int x = 6;

    cout << "���� �ּҰ��� " << x << " " << &x << endl;

    doSomething(x);
    doSomething(x + 1);

    return 0;
}
