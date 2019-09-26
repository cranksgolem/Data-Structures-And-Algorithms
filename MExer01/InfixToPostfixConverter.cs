using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MExer02;
using StackImplementations;

namespace MExer01
{
    public static class InfixToPostfixConverter
    {
        public static QueueUsingDoublyLinkedList<string> ConvertToPostfix(string exp)
        {
            var postfix = new QueueUsingDoublyLinkedList<string>();
            StackUsingLinkedList<char> stack = new StackUsingLinkedList<char>();
            StringBuilder num = new StringBuilder();

            for (int x = 0; x < exp.Length; x++)
            {
                if (Char.IsDigit(exp[x]) == true)
                {
                    if (x != exp.Length - 1 && (Char.IsDigit(exp[x + 1]) == true || exp[x + 1] == '.' || exp[x+1] == ','))
                    {
                        num.Append(exp[x]);
                    }

                    else
                    {
                        num.Append(exp[x]);
                        postfix.Enqueue(num.ToString());
                        num.Clear();
                        if (x != exp.Length - 1 && exp[x + 1] == '(')
                        {
                            while (!stack.IsEmpty() && IsOperator(stack.Peek()) && GreaterOrEqualPrecedence('*', stack.Peek()) == true)
                            {
                                postfix.Enqueue(stack.Pop().ToString());
                            }
                            stack.Push('*');
                        }
                    }
                }

                else if (exp[x] == '.')
                {
                    num.Append(exp[x]);
                }

                else if (exp[x] == '-')
                {

                    if (x == 0 || IsOperator(exp[x - 1]) == true || exp[x - 1] == '(')
                    {
                        if (exp.Length != 1 && x != exp.Length - 1 && exp[x + 1] == '(')
                        {
                            exp = exp.Substring(0, x + 1) + '1' + exp.Substring(x + 1);
                        }

                        num.Append(exp[x]);
                    }

                    else
                    {
                        while (!stack.IsEmpty() && IsOperator(stack.Peek()) && GreaterOrEqualPrecedence(exp[x], stack.Peek()) == true)
                        {
                            postfix.Enqueue(stack.Pop().ToString());
                        }
                        stack.Push(exp[x]);
                    }

                }

                else if (exp[x] == '(')
                {
                    stack.Push(exp[x]);
                }

                else if (IsOperator(exp[x]) == true)
                {
                    while (!stack.IsEmpty() && IsOperator(stack.Peek()) && GreaterOrEqualPrecedence(exp[x], stack.Peek()) == true)
                    {
                        postfix.Enqueue(stack.Pop().ToString());
                    }
                    stack.Push(exp[x]);
                }

                else if (exp[x] == ')')
                {

                    while (stack.Peek() != '(')
                    {
                        postfix.Enqueue(stack.Pop().ToString());
                    }

                    stack.Pop();

                    if (x != exp.Length - 1 && exp[x + 1] == '(')
                    {
                        while (!stack.IsEmpty() && IsOperator(stack.Peek()) && GreaterOrEqualPrecedence('*', stack.Peek()) == true)
                        {
                            postfix.Enqueue(stack.Pop().ToString());
                        }
                        stack.Push('*');
                    }
                }
            }

            while (!stack.IsEmpty())
            {
                postfix.Enqueue(stack.Pop().ToString());
            }

            return postfix;
        }


        public static bool IsOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
            {
                return true;
            }
            else
                return false;
        }

        public static int ReturnPrecedence(char op)
        {
            if (op == '+' || op == '-')
            {
                return 1;
            }

            else if (op == '*' || op == '/')
            {
                return 2;
            }

            else if (op == '^')
            {
                return 3;
            }

            else
            {
                return 0;
            }
        }

        public static bool GreaterOrEqualPrecedence(char operator1, char operator2)
        {
            int op1 = ReturnPrecedence(operator1);
            int op2 = ReturnPrecedence(operator2);

            if (op2 >= op1)
            {
                return true;
            }

            else
                return false;
        }
    }
}
