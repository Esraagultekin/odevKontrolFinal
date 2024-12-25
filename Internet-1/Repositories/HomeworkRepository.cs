using AutoMapper;
using Internet_1.Repositories;
using Internet_1.Models;
using Internet_1.ViewModels;


namespace Internet_1.Repositories
{


    public class HomeworkRepository : GenericRepository<Homework>
    {
        public HomeworkRepository(AppDbContext context) : base(context)
        {
        }

    }
}
    //----GENERICREPOSITORY ÖNCESİ----

//public class HomeworkRepository
//{
//    private readonly AppDbContext _context;
//    private readonly IMapper _mapper;
//    public HomeworkRepository(AppDbContext context, IMapper mapper)
//    {
//        _context = context;
//        _mapper = mapper;
//    }
//    public List<HomeworkModel> GetList()
//    {
//        var homeworks = _context.Homeworks.ToList();
//        var homeworkModels = _mapper.Map<List<HomeworkModel>>(homeworks);
//        return homeworkModels;

//    }
//    public HomeworkModel GetById(int id)
//    {
//        var homeworks = _context.Homeworks.Where(s => s.Id == id).FirstOrDefault();
//        var homeworkModels = _mapper.Map<HomeworkModel>(homeworks);
//        return homeworkModels;
//    }
//    public void Add(HomeworkModel model)
//    {
//        var homework = _mapper.Map<Homework>(model);
//        _context.Homeworks.Add(homework);
//        _context.SaveChanges();
//    }
//    public void Update(HomeworkModel model)   //Veritabanından kaydı alır. homework değişkenine atar.Update ile veritabanında bilgileri günceller
//                                              //Savechanges ile bu değişikleri kaydeder.Tüm bu işlemler id ile eşleşen kayıt varsa yapılır.
//    {
//        var homework = _context.Homeworks.Where(s => s.Id == model.Id).FirstOrDefault();
//        if (homework != null)
//        {
//            homework.Name = model.Name;
//            homework.Description = model.Description;
//            homework.StudentNumber = model.StudentNumber;
//            homework.IsActive = model.IsActive;
//            homework.StudentId = model.StudentId;

//            _context.Homeworks.Update(homework);
//            _context.SaveChanges();
//        }
//    }
//    public void Delete(int id)
//    {
//        var homework = _context.Homeworks.Where(s => s.Id == id).FirstOrDefault();
//        if (homework != null)
//        {
//            _context.Homeworks.Remove(homework);
//            _context.SaveChanges();
//        }

           
//            }
//}

