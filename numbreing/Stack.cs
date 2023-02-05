namespace numbreing
{
    class Stack : NodeStack
    {
        public int top;
        public string word;
        public NodeStack head;
        public Stack()
        {
            head = null;
            top = -1;
        }
        public void push(string item)
        {
            NodeStack temp = new NodeStack();
            temp.data = item;
            temp.next = head;
            head = temp;
            top++;
        }
        public bool pop()
        {
            if (is_empty())
            {
               
                return false; 
            }

            head = head.next;
            top--;
            return true;
        }
        public bool is_empty()
        {
            return top < 0;
        }
        public string peek()
        {
            return head.data;
        }
        public string display()
        {
           
            NodeStack p = head;
            while (p != null)
            {
                word += p.data + '\n';
                p = p.next;
            }
            return word;
        }

    }
}
