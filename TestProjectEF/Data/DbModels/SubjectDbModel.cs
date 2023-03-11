namespace TestProjectEF.Data.DbModels
{
    public class SubjectDbModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StudentDbModel Student { get; set; }
        public Guid StudentId { get; set; }
        public TeacherDbModel Teacher { get; set; }
        public Guid TeacherId { get; set; }
    }
}
