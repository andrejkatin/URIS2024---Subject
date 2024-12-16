using URIS2024___Subject.Models;

namespace URIS2024___Subject.Data
{
    public class SubjectRepository : ISubjectRepository
    {
        private List<SubjectEntity> Subjects { get; set; }
        public SubjectRepository() 
        {
            Subjects = new List<SubjectEntity>();
            FillData();
        }

        private void FillData()
        { 
            Subjects.AddRange(new List<SubjectEntity>
            {
                new SubjectEntity
                {
                    Id = Guid.Parse("21ad52f8-0281-4241-98b0-481566d25e4f"),
                    Name = "Upravljanje razvojem informacionih sistema",
                    ECTS = 6
                },
                new SubjectEntity
                {
                    Id = Guid.Parse("9d8bab08-f442-4297-8ab5-ddfe08e335f3"),
                    Name = "Projektovanje skladista podataka",
                    ECTS = 6
                },
            });
        }

        public SubjectEntity GetSubjectEntityById(Guid id)
        {
            return Subjects.FirstOrDefault(s => s.Id == id);
        }
    }
}
