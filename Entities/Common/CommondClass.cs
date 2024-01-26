namespace StartupCase_Entities.Common
{
    public  abstract class CommondClass
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
