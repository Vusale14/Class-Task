namespace Academy_Task.Entities
{
    public class GroupTeacherInformation
    {
        public int Id { get; set; }
        public int GroupId {  get; set; }
        public int TeacherId { get; set; }
        public int InformationId { get; set; }
        public Group Group { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;
        public Information Information { get; set; } = null!;
    }
}
