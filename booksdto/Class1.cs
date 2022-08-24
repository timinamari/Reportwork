namespace booksdto
{
    public class Class1
    {
        public List<string> Readers { get; set; } //ключ
        public List<string> Books { get; set; } //значение
        public Dictionary<string, List<string>> Informations  { get; set; }
    }

  
}