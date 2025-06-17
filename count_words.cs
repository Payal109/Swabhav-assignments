namespace count_words
{
    internal class countwords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---count words---");
            Console.WriteLine("enter a setence");
            String sentence = Console.ReadLine();
            int WordCount = 0;
            bool Inword = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];

                if (c != ' ' && c != '\t' && c != '\n')

                {
                    if (!Inword)
                    {
                        WordCount++;
                        Inword = true;
                    }
                }

                else
                {
                    Inword = false;
                }
            }
        Console.WriteLine(" the count of words is : " + WordCount);



            
        }
    }
}
