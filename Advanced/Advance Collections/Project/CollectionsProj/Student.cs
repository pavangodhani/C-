namespace CollectionsProj
{
    class Student
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        
    }
}