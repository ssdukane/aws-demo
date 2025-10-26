namespace efapi1.Infra.Domain.Entities;

public abstract  class Auditable : Entity, ICreatible
{
    public string CreateBy { get; set; }
    public DateTime CreateDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
  
}

