/* 값에 의한 인수 전달. Call by value */
#include <iostream>

using namespace std;

void doSomething(int y)
{
    cout << "함수한태 불려갔을 땐 " << y << " " << &y << endl;
}

int main()
{
    int x = 6;

    cout << "원래 주소값은 " << x << " " << &x << endl;

    doSomething(x);
    doSomething(x + 1);

    return 0;
}
