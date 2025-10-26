namespace efapi1.Infra.Domain.Entities;
public interface ICreatible
{
    public string CreateBy { get; }
    public DateTime CreateDate { get; }
}
