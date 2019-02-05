using System;
using System.Numerics;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine().ToLower();

        while (opCode != "end")
        {
            string[] codeArgs = opCode.Split(' ');

            BigInteger  result = 0;
            switch (codeArgs[0].ToLower())
            {
                case "inc":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                case "dec":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                case "add":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                        BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
            }
            Console.WriteLine(result);
            opCode = Console.ReadLine().ToLower();
        }
    }
}