namespace Trees
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} ({Role})";
        }
    }
}
