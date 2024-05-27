using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Entities;

public class Category(string name)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;

    public Category() : this(string.Empty)
    {
    }
    
    public ICollection<Tutorial> Tutorials { get; } 
}