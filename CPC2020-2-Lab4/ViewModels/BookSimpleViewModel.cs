namespace CPC2020_2_Lab4
{
    /// <summary>
    /// prosty model ksiązki przechowujące podstawowe dane do wyświetlenia
    /// </summary>
    public class BookSimpleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public int YearOfPublish { get; set; }
    }
}
