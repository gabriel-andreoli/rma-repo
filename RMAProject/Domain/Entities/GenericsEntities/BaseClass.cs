namespace RMAProject.Domain.Entities.GenericsEntities
{
    public class BaseClass
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public void DeleteMe() 
        {
            Deleted = true;
            UpdateMe();
        }

        public void ReactiveMe() 
        {
            Deleted = false;
            UpdateMe();
        }

        public void UpdateMe() => UpdatedAt = DateTime.UtcNow;
    }
}
