//Un-comment below code and fix the issues
//Push to github


// This is a fixed version of the function.
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    
    if(count == 0) {
        return first+second;
    }else{
        return RecursiveFibonacci(second, first+second, count);
    }
}

// Though I would personally do it like this instead: 
int RecursiveFibonacci2(int count){
    switch(count){
        case 0:
            return 0;
        case 1:
            return 1;
        default:
            return RecursiveFibonacci2(count-1)+RecursiveFibonacci2(count-2);
    }
}
// This is much more user friendly, as you can simply choose your desired index without worrying about other parameters.
// Secondly, the first solution can easily be recreated as an *interative* solution, 
// while the second solution takes advantage of recursion in a way that would be complicated if done iteratively.
// To get the number "13", you can simply use "7" as the parameter, as it is the 7th fibonacci number (well, it depends who you ask).

// So, if you absolutely want to find a fibonacci number from the parameters "int first, int second, int count", 
// is there any need to do it recusrively? The iterative function below works just as well, with just as much code,
// and is just as, if not more understandable.

int IterativeFibonacci(int first, int second, int count){
    for(int i = 0; i < count; i++){
        int tempFirst = first;
        first = second;
        second += tempFirst;
    }
    return second;
}

int lastFibo = RecursiveFibonacci2(7);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 
