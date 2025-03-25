namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Bracket { get; set; }
            public Node Next { get; set; }

            public Node(char bracket)
            {
                Bracket = bracket;
                Next = null;
            }
        }

        private Node top;

        public BracketValidator()
        {
            top = null;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (var ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[') {
                    Push(ch);
                } else if (ch == ')' || ch == '}' || ch == ']') {
                    if (top == null || !IsMatchingPair(Pop(), ch)) {
                        return false;
                    }
                }
            }
            return top == null;
        }

        private void Push(char bracket)
        {
            Node nodeBaru = new Node(bracket);
            nodeBaru.Next = top;
            top = nodeBaru;
        }

        private char Pop()
        {
            if (top == null) {
                return '\0';
            }
            
            char bracket = top.Bracket;
            top = top.Next;
            return bracket;
        }

        private bool IsMatchingPair(char buka, char tutup)
        {
            return (buka == '(' && tutup == ')') || (buka == '{' && tutup == '}') || (buka == '[' && tutup == ']');
        }
    }
}