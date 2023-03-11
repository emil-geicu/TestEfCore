namespace TestProjectEF.Data.DbModels
{
    public class StudentDbModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
           
        public ICollection<SubjectDbModel> Subjects { get; set; }
    }
}
