using URIS2024___Subject.Models;

namespace URIS2024___Subject.Data
{
    public interface ISubjectRepository
    {
        SubjectEntity GetSubjectEntityById(Guid id);
    }
}
