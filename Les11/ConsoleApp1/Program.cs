namespace MyNamespace
{
    class Notebook
    {
        public string Title { get; set; }
        public int NumPages { get; set; }

        public virtual int GetCost()
        {
            return 15 * NumPages;
        }
    }

    class GeneralNotebook : Notebook
    {
        public string CoverMaterial { get; set; }

        public override int GetCost()
        {
            int baseCost = base.GetCost();
            return baseCost + 50; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook { Title = "Тонкая тетрадь", NumPages = 12 };
            Console.WriteLine(notebook.GetCost());

            GeneralNotebook generalNotebook = new GeneralNotebook { Title = "Полуобщая тетрадь", NumPages = 50, CoverMaterial = "Голографический пластик" };
            Console.WriteLine(generalNotebook.GetCost());
        }
    }
}