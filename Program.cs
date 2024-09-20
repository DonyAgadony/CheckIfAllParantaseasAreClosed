class Program
{
    public static void Main()
    {

    }
    public static bool IsBalanced(Stack<char> stack)
    {
        int countForward = 0;
        int countBackwards = 0;
        if (stack.Pop() != ')')
        {
            return false;
        }
        while (stack.Count > 1)
        {
            if (stack.Pop() == ')') { countBackwards++; }
            else if (stack.Pop() == '(') { countForward++; }
            else { return false; }
        }
        if (stack.Pop() != '(') { return false; }
        return true;
    }
}