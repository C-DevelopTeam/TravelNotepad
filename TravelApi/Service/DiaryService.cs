using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface IDiaryService : IEntityService<Diary>
    {
    }

    public class DiaryService : EntityService<Diary>, IDiaryService
    {
        public DiaryService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Diary> GetDiaryByDate(string date)
        {
            return this.dbset.Where(d => d.DiaryId.ToString().StartsWith(date)).OrderBy(d => d.DiaryId);
        }
        
        public IQueryable<Diary> GetByShare()
        {
            return this.dbset.Where(d =>d.Share==1);
        }

        public Diary GetById(long diaryId)
        {
            return this.dbset.FirstOrDefault(t => t.DiaryId == diaryId);
        }
    }
}