namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; set; }
        
        public Halaman(string url)
        {
            URL = url;
        }
    }

    public class HistoryManager
    {
        private class Node
        {
            public Halaman Halaman { get; set; }
            public Node Next { get; set; }
            
            public Node(Halaman halaman)
            {
                Halaman = halaman;
                Next = null;
            }
        }

        private Node top;

        public HistoryManager()
        {
            top = null;
        }

        public void KunjungiHalaman(string url)
        {
            Halaman halamanBaru = new Halaman(url);
            Node nodeBaru = new Node(halamanBaru);
            nodeBaru.Next = top;
            top = nodeBaru;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string Kembali()
        {
            if (top == null || top.Next == null) {
                return "Tidak ada halaman sebelumnya.";
            }

            top = top.Next;
            return top.Halaman.URL;
        }

        public string LihatHalamanSaatIni()
        {
            return top?.Halaman.URL;
        }

        public void TampilkanHistory()
        {
            Node current = top;
            Stack<string> historyStack = new Stack<string>();

            while (current != null) {
                historyStack.Push(current.Halaman.URL);
                current = current.Next;
            }

            while (historyStack.Count > 0) {
                Console.WriteLine(historyStack.Pop());
            }
        }
    }
}