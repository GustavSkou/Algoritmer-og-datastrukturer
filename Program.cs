using System.Runtime.CompilerServices;

int CharCount(string s, char c) {
    if (s.Length == 0)
        return 0;

    if(s[0] == c)
        return CharCount(s.Substring(1), c) + 1;
    
    return CharCount(s.Substring(1), c);
}
Console.WriteLine($"banana = {CharCount("banana", 'a')}");

int logTwo(int N) {
    if (N == 2)
        return 1;

    return logTwo(N/2) + 1;
}
Console.WriteLine($"log(32)={logTwo(32)}, log(4096)={logTwo(4096)}");

int sum(int n)
{
    if (n == 0) {
        return 0;
    }

    if (n % 2 == 0) {
        return sum(n - 1);
    }

    return sum(n - 1) + n;
}
Console.WriteLine(sum(5));

/*
int evenSquares(int n)
{
    
}
*/

int fib(int n)
{
    if (n == 0 ) {
        return 0;
    }

    if (n == 1) {
        return 1;
    }

    return fib(n - 1) + fib(n - 2);
}
Console.WriteLine(fib(6));

bool linear(string s, char c, int l)
{
    if (l == 0) 
        return false;
    
    if (s[0]==c)
        return true;

    return linear(s[1..], c, l-1);
}
Console.WriteLine(linear("abc", 'd', 3));

bool binarySearch(int[] arr, int value)
{
    if (arr.Length == 0)
        return false;

    int middle = arr.Length/2;
    int middleValue = arr[middle];

    if (middleValue == value)
        return true;

    if (arr.Length == 1)
        return false;
    
    if (middleValue < value) 
        return binarySearch(arr[middle..], value);

    return binarySearch(arr[..middle], value);
}

Console.WriteLine(binarySearch([1,2,3,6,7,8,12,32,123], 3));    

