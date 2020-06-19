using System.Linq;
using TravelApi.Models;
using TravelApi.Dao;

namespace TravelApi.Service
{
    public interface IDiaryService : IEntityService<Diary>
    {
        IQueryable<Diary> GetDiaryByDate(string date);
        IQueryable<Diary> GetByShare();
        Diary GetById(long diaryId);
        IQueryable<Diary> GetShareByUid(int uid);
        IQueryable<Diary> GetDiaryByUid(int uid);
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
            return this.dbset.Where(d =>d.Share==1).OrderByDescending(d=>d.Time);
        }

        public Diary GetById(long diaryId)
        {
            return this.dbset.FirstOrDefault(t => t.DiaryId == diaryId);
        }

        public IQueryable<Diary> GetShareByUid(int uid)
        {
            return this.dbset.Where(d => d.Uid == uid && d.Share == 1).OrderByDescending(d=>d.Time);
        }

        public IQueryable<Diary> GetDiaryByUid(int uid)
        {
            return this.dbset.Where(d => d.Uid == uid).OrderByDescending(d=>d.Time);
        }
    }
}