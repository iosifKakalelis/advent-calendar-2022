Stack<String> stack1 = new Stack<String>();

stack1.Push("W");
stack1.Push("D");
stack1.Push("G");
stack1.Push("B");
stack1.Push("H");
stack1.Push("R");
stack1.Push("V");

Stack<String> stack2 = new Stack<String>();

stack2.Push("J");
stack2.Push("N");
stack2.Push("G");
stack2.Push("C");
stack2.Push("R");
stack2.Push("F");



Stack<String> stack3 = new Stack<String>();

stack3.Push("L");
stack3.Push("S");
stack3.Push("F");
stack3.Push("H");
stack3.Push("D");
stack3.Push("N");
stack3.Push("J");

Stack<String> stack4 = new Stack<String>();

stack4.Push("J");
stack4.Push("D");
stack4.Push("S");
stack4.Push("V");

Stack<String> stack5 = new Stack<String>();
stack5.Push("S");
stack5.Push("H");
stack5.Push("D");
stack5.Push("R");
stack5.Push("Q");
stack5.Push("W");
stack5.Push("N");
stack5.Push("V");

Stack<String> stack6 = new Stack<String>();
stack6.Push("P");
stack6.Push("G");
stack6.Push("H");
stack6.Push("C");
stack6.Push("M");

Stack<String> stack7 = new Stack<String>();
stack7.Push("F");
stack7.Push("J");
stack7.Push("B");
stack7.Push("G");
stack7.Push("L");
stack7.Push("Z");
stack7.Push("H");
stack7.Push("C");

Stack<String> stack8 = new Stack<String>();
stack8.Push("S");
stack8.Push("J");
stack8.Push("R");



Stack<String> stack9 = new Stack<String>();
stack9.Push("L");
stack9.Push("G");
stack9.Push("S");
stack9.Push("R");
stack9.Push("B");
stack9.Push("N");
stack9.Push("V");
stack9.Push("M");

IDictionary<int, Stack<String>> stacks = new Dictionary<int, Stack<String>>();
stacks.Add(1, stack1);
stacks.Add(2, stack2);
stacks.Add(3, stack3);
stacks.Add(4, stack4);
stacks.Add(5, stack5);
stacks.Add(6, stack6);
stacks.Add(7, stack7);
stacks.Add(8, stack8);
stacks.Add(9, stack9);






string moves = """
    move 2 from 2 to 7
    move 8 from 5 to 6
    move 2 from 4 to 5
    move 1 from 4 to 5
    move 1 from 5 to 8
    move 5 from 9 to 2
    move 7 from 1 to 6
    move 7 from 3 to 8
    move 1 from 4 to 6
    move 2 from 5 to 6
    move 6 from 7 to 5
    move 2 from 2 to 4
    move 4 from 5 to 2
    move 10 from 8 to 1
    move 2 from 7 to 4
    move 4 from 2 to 8
    move 2 from 9 to 8
    move 1 from 8 to 4
    move 2 from 4 to 9
    move 5 from 8 to 2
    move 1 from 4 to 6
    move 1 from 8 to 9
    move 1 from 7 to 2
    move 2 from 4 to 2
    move 1 from 7 to 3
    move 13 from 2 to 1
    move 1 from 2 to 4
    move 1 from 2 to 3
    move 2 from 5 to 4
    move 17 from 6 to 4
    move 3 from 4 to 9
    move 14 from 1 to 4
    move 4 from 6 to 8
    move 1 from 9 to 8
    move 23 from 4 to 8
    move 6 from 1 to 7
    move 3 from 1 to 5
    move 1 from 3 to 8
    move 5 from 7 to 8
    move 1 from 3 to 4
    move 1 from 5 to 3
    move 1 from 5 to 1
    move 1 from 3 to 2
    move 1 from 9 to 4
    move 9 from 4 to 9
    move 1 from 1 to 2
    move 11 from 8 to 2
    move 1 from 4 to 5
    move 13 from 2 to 3
    move 7 from 9 to 6
    move 1 from 5 to 6
    move 1 from 5 to 2
    move 1 from 9 to 4
    move 1 from 4 to 9
    move 2 from 8 to 9
    move 1 from 7 to 8
    move 8 from 9 to 1
    move 8 from 1 to 4
    move 4 from 6 to 7
    move 1 from 9 to 4
    move 2 from 3 to 9
    move 1 from 9 to 1
    move 6 from 4 to 1
    move 2 from 1 to 3
    move 22 from 8 to 6
    move 1 from 2 to 5
    move 3 from 7 to 8
    move 15 from 6 to 4
    move 7 from 3 to 7
    move 4 from 6 to 9
    move 2 from 9 to 2
    move 6 from 3 to 5
    move 3 from 9 to 5
    move 5 from 5 to 8
    move 1 from 2 to 1
    move 6 from 8 to 2
    move 1 from 1 to 2
    move 3 from 5 to 3
    move 1 from 7 to 2
    move 4 from 7 to 8
    move 4 from 6 to 1
    move 1 from 5 to 1
    move 4 from 8 to 7
    move 2 from 3 to 2
    move 1 from 1 to 3
    move 15 from 4 to 2
    move 3 from 7 to 3
    move 4 from 7 to 2
    move 1 from 4 to 9
    move 5 from 3 to 8
    move 29 from 2 to 1
    move 1 from 9 to 5
    move 1 from 2 to 1
    move 11 from 1 to 5
    move 1 from 4 to 5
    move 2 from 6 to 3
    move 1 from 3 to 4
    move 16 from 1 to 9
    move 4 from 8 to 4
    move 3 from 6 to 9
    move 1 from 3 to 7
    move 1 from 7 to 3
    move 6 from 1 to 6
    move 3 from 4 to 3
    move 3 from 8 to 5
    move 3 from 1 to 8
    move 3 from 1 to 4
    move 2 from 4 to 9
    move 3 from 6 to 3
    move 15 from 5 to 2
    move 3 from 2 to 3
    move 4 from 2 to 7
    move 2 from 5 to 9
    move 10 from 3 to 6
    move 11 from 9 to 5
    move 2 from 4 to 9
    move 8 from 9 to 4
    move 1 from 9 to 6
    move 7 from 4 to 6
    move 3 from 5 to 8
    move 22 from 6 to 9
    move 4 from 7 to 8
    move 8 from 5 to 8
    move 2 from 4 to 3
    move 1 from 8 to 1
    move 17 from 8 to 3
    move 3 from 3 to 4
    move 13 from 3 to 9
    move 20 from 9 to 7
    move 2 from 2 to 9
    move 19 from 9 to 5
    move 1 from 1 to 4
    move 3 from 2 to 7
    move 4 from 4 to 3
    move 1 from 9 to 8
    move 18 from 5 to 1
    move 1 from 9 to 4
    move 1 from 9 to 7
    move 2 from 4 to 8
    move 1 from 5 to 4
    move 3 from 2 to 7
    move 3 from 3 to 1
    move 2 from 1 to 3
    move 3 from 3 to 8
    move 1 from 4 to 8
    move 6 from 8 to 2
    move 1 from 3 to 9
    move 1 from 3 to 9
    move 10 from 1 to 9
    move 7 from 1 to 7
    move 4 from 7 to 4
    move 29 from 7 to 3
    move 6 from 2 to 9
    move 25 from 3 to 6
    move 5 from 3 to 9
    move 13 from 6 to 9
    move 12 from 6 to 2
    move 1 from 8 to 9
    move 10 from 2 to 6
    move 7 from 6 to 5
    move 20 from 9 to 3
    move 11 from 3 to 6
    move 1 from 7 to 9
    move 2 from 2 to 9
    move 19 from 9 to 2
    move 14 from 6 to 8
    move 4 from 5 to 2
    move 2 from 4 to 6
    move 3 from 5 to 1
    move 13 from 8 to 5
    move 1 from 6 to 1
    move 2 from 4 to 2
    move 8 from 2 to 4
    move 6 from 4 to 7
    move 1 from 9 to 8
    move 2 from 4 to 7
    move 5 from 2 to 4
    move 4 from 4 to 2
    move 10 from 5 to 6
    move 1 from 1 to 7
    move 1 from 5 to 4
    move 1 from 4 to 9
    move 4 from 7 to 8
    move 5 from 1 to 7
    move 1 from 9 to 7
    move 7 from 3 to 2
    move 2 from 5 to 2
    move 8 from 6 to 9
    move 1 from 4 to 6
    move 3 from 7 to 4
    move 5 from 9 to 7
    move 2 from 4 to 3
    move 20 from 2 to 4
    move 2 from 4 to 8
    move 14 from 4 to 2
    move 12 from 7 to 4
    move 8 from 2 to 1
    move 10 from 2 to 4
    move 6 from 8 to 5
    move 1 from 7 to 8
    move 4 from 4 to 3
    move 1 from 3 to 9
    move 1 from 2 to 7
    move 1 from 6 to 8
    move 5 from 3 to 5
    move 1 from 3 to 2
    move 7 from 4 to 5
    move 6 from 1 to 7
    move 5 from 7 to 6
    move 1 from 6 to 5
    move 2 from 7 to 8
    move 1 from 2 to 6
    move 2 from 8 to 2
    move 5 from 5 to 7
    move 6 from 6 to 8
    move 16 from 4 to 9
    move 16 from 9 to 4
    move 11 from 5 to 4
    move 5 from 8 to 3
    move 2 from 5 to 2
    move 14 from 4 to 2
    move 1 from 6 to 3
    move 1 from 6 to 9
    move 1 from 5 to 3
    move 3 from 8 to 2
    move 10 from 4 to 7
    move 5 from 9 to 2
    move 3 from 4 to 7
    move 1 from 1 to 4
    move 3 from 2 to 5
    move 2 from 3 to 7
    move 1 from 4 to 2
    move 18 from 2 to 8
    move 3 from 8 to 4
    move 5 from 3 to 1
    move 1 from 3 to 9
    move 1 from 9 to 3
    move 8 from 8 to 7
    move 2 from 5 to 4
    move 1 from 5 to 6
    move 1 from 2 to 5
    move 1 from 5 to 8
    move 1 from 6 to 9
    move 3 from 2 to 7
    move 27 from 7 to 4
    move 2 from 2 to 4
    move 4 from 8 to 4
    move 1 from 9 to 8
    move 3 from 1 to 6
    move 1 from 3 to 5
    move 3 from 8 to 3
    move 1 from 1 to 4
    move 1 from 8 to 1
    move 3 from 1 to 4
    move 2 from 8 to 2
    move 2 from 6 to 2
    move 8 from 4 to 9
    move 1 from 7 to 1
    move 1 from 5 to 4
    move 1 from 7 to 3
    move 4 from 2 to 7
    move 1 from 8 to 6
    move 8 from 9 to 7
    move 1 from 6 to 3
    move 3 from 3 to 4
    move 37 from 4 to 1
    move 1 from 4 to 5
    move 13 from 7 to 8
    move 6 from 8 to 4
    move 5 from 8 to 3
    move 1 from 7 to 6
    move 4 from 1 to 5
    move 1 from 6 to 5
    move 2 from 8 to 4
    move 32 from 1 to 5
    move 1 from 1 to 4
    move 5 from 3 to 5
    move 1 from 3 to 2
    move 1 from 2 to 9
    move 19 from 5 to 2
    move 1 from 9 to 1
    move 16 from 5 to 1
    move 7 from 5 to 6
    move 1 from 3 to 1
    move 11 from 1 to 2
    move 18 from 2 to 4
    move 1 from 5 to 9
    move 8 from 6 to 1
    move 10 from 2 to 6
    move 7 from 4 to 9
    move 2 from 2 to 1
    move 7 from 4 to 2
    move 5 from 4 to 5
    move 2 from 9 to 6
    move 9 from 6 to 3
    move 5 from 5 to 3
    move 8 from 4 to 9
    move 7 from 9 to 8
    move 4 from 2 to 9
    move 10 from 3 to 1
    move 6 from 8 to 1
    move 2 from 6 to 3
    move 5 from 3 to 8
    move 3 from 2 to 7
    move 1 from 9 to 5
    move 1 from 3 to 5
    move 2 from 7 to 8
    move 1 from 8 to 9
    move 1 from 6 to 1
    move 23 from 1 to 4
    move 2 from 5 to 3
    move 1 from 8 to 2
    move 2 from 8 to 5
    move 2 from 5 to 6
    move 1 from 2 to 7
    move 1 from 7 to 5
    move 4 from 9 to 7
    move 1 from 7 to 5
    move 1 from 3 to 6
    move 3 from 7 to 4
    move 1 from 3 to 8
    move 1 from 4 to 6
    move 6 from 1 to 8
    move 4 from 6 to 4
    move 2 from 9 to 1
    move 1 from 5 to 1
    move 19 from 4 to 2
    move 2 from 9 to 3
    move 1 from 9 to 3
    move 9 from 1 to 8
    move 1 from 5 to 8
    move 1 from 9 to 3
    move 2 from 3 to 9
    move 3 from 8 to 4
    move 1 from 4 to 9
    move 1 from 9 to 5
    move 2 from 3 to 4
    move 6 from 4 to 7
    move 3 from 9 to 5
    move 4 from 4 to 7
    move 1 from 5 to 6
    move 18 from 2 to 7
    move 13 from 7 to 9
    move 3 from 5 to 1
    move 1 from 2 to 1
    move 1 from 6 to 5
    move 3 from 1 to 7
    move 1 from 1 to 5
    move 7 from 9 to 6
    move 8 from 7 to 4
    move 11 from 7 to 6
    move 5 from 9 to 2
    move 17 from 6 to 1
    move 2 from 5 to 1
    move 11 from 8 to 1
    move 20 from 1 to 2
    move 3 from 8 to 1
    move 1 from 9 to 8
    move 1 from 6 to 1
    move 11 from 1 to 7
    move 18 from 2 to 3
    move 12 from 4 to 8
    move 11 from 7 to 3
    move 7 from 2 to 3
    move 2 from 1 to 5
    move 1 from 1 to 3
    move 1 from 8 to 1
    move 1 from 5 to 9
    move 1 from 9 to 6
    move 1 from 8 to 7
    move 1 from 5 to 3
    move 1 from 6 to 7
    move 2 from 8 to 1
    move 8 from 3 to 2
    move 7 from 2 to 9
    move 6 from 8 to 6
    move 1 from 9 to 3
    move 2 from 6 to 4
    move 5 from 9 to 6
    move 7 from 6 to 2
    move 8 from 2 to 9
    move 2 from 1 to 9
    move 2 from 7 to 2
    move 2 from 4 to 8
    move 1 from 2 to 7
    move 25 from 3 to 7
    move 7 from 9 to 7
    move 1 from 2 to 5
    move 1 from 1 to 4
    move 3 from 8 to 1
    move 3 from 1 to 8
    move 3 from 7 to 8
    move 15 from 7 to 3
    move 10 from 8 to 3
    move 1 from 5 to 7
    move 1 from 8 to 5
    move 3 from 9 to 2
    move 1 from 6 to 4
    move 2 from 2 to 7
    move 1 from 2 to 5
    move 14 from 7 to 9
    move 1 from 6 to 2
    move 1 from 7 to 1
    move 1 from 5 to 4
    move 3 from 4 to 3
    move 1 from 7 to 6
    move 1 from 2 to 7
    move 1 from 1 to 2
    move 3 from 9 to 1
    move 1 from 6 to 2
    move 2 from 2 to 6
    move 17 from 3 to 6
    move 1 from 8 to 3
    move 1 from 5 to 4
    move 2 from 7 to 2
    move 9 from 9 to 8
    move 1 from 9 to 3
    move 16 from 3 to 2
    move 1 from 7 to 5
    move 5 from 6 to 5
    move 1 from 1 to 6
    move 1 from 4 to 1
    move 1 from 9 to 3
    move 9 from 8 to 6
    move 3 from 1 to 5
    move 1 from 9 to 1
    move 16 from 2 to 1
    move 2 from 2 to 7
    move 2 from 3 to 9
    move 2 from 7 to 4
    move 2 from 9 to 3
    move 3 from 3 to 5
    move 1 from 4 to 5
    move 1 from 4 to 2
    move 1 from 1 to 7
    move 1 from 7 to 1
    move 1 from 3 to 6
    move 2 from 5 to 1
    move 3 from 6 to 2
    move 2 from 5 to 8
    move 8 from 5 to 4
    move 1 from 5 to 3
    move 1 from 3 to 2
    move 1 from 8 to 3
    move 1 from 3 to 8
    move 4 from 1 to 7
    move 9 from 1 to 7
    move 6 from 1 to 8
    move 3 from 7 to 4
    move 7 from 6 to 7
    move 11 from 4 to 3
    move 2 from 3 to 8
    move 8 from 3 to 8
    move 4 from 6 to 1
    move 1 from 7 to 4
    move 2 from 1 to 2
    move 8 from 7 to 2
    move 1 from 4 to 8
    move 10 from 8 to 2
    move 2 from 6 to 1
    move 1 from 1 to 4
    move 1 from 4 to 8
    move 2 from 1 to 4
    move 6 from 6 to 5
    move 1 from 1 to 9
    move 2 from 6 to 8
    move 1 from 4 to 5
    move 1 from 6 to 9
    move 4 from 8 to 9
    move 1 from 7 to 1
    move 6 from 8 to 6
    move 1 from 6 to 1
    move 1 from 4 to 9
    move 2 from 9 to 5
    move 5 from 5 to 9
    move 8 from 9 to 5
    move 2 from 8 to 5
    move 3 from 6 to 9
    move 8 from 5 to 7
    move 5 from 5 to 6
    move 1 from 9 to 2
    move 1 from 3 to 1
    move 1 from 6 to 7
    move 1 from 5 to 6
    move 24 from 2 to 4
    move 3 from 9 to 7
    move 16 from 4 to 5
    move 2 from 1 to 3
    move 12 from 5 to 6
    move 1 from 9 to 5
    move 4 from 5 to 9
    move 1 from 1 to 6
    move 1 from 5 to 2
    move 2 from 9 to 8
    move 1 from 8 to 1
    move 5 from 4 to 5
    move 2 from 3 to 5
    move 1 from 8 to 3
    move 1 from 1 to 6
    move 3 from 5 to 7
    move 1 from 9 to 1
    move 1 from 2 to 8
    """;

String[] movesArray = moves.Split("\r\n");

foreach (String move in movesArray)
{
    var moveArray = move.Split(" ");
    int step = int.Parse(moveArray[1]);
    int source = int.Parse(moveArray[3]);
    int destination = int.Parse(moveArray[5]);
    Stack<String> stackDestination = new Stack<String>();
    Stack<String> stackSource = new Stack<String>();


    if (stacks.TryGetValue(source, out stackSource) && stacks.TryGetValue(destination, out stackDestination))
    {
        Stack<String> stackTemp = new Stack<String>();
        for (int i = 0; i < step; i++)
        {


            stackTemp.Push(stackSource.Pop());

        }


        while (stackTemp.Count > 0)
        {
            stackDestination.Push(stackTemp.Pop());
        }




    }

}


//use ElementAt() to retrieve key-value pair using index
for (int i = 0; i < stacks.Count; i++)
{
    Console.WriteLine("Key: {0}, Value: {1}",
                                            stacks.ElementAt(i).Key,
                                            stacks.ElementAt(i).Value.Peek());
}
