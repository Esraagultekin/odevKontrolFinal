using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Internet_1.Models;
using Internet_1.Repositories;
using Internet_1.ViewModels;

namespace Internet_1.Controllers
{
    public class TosubmitController : Controller
    {
        private readonly TosubmitRepository _tosubmitRepository;
        private readonly IMapper _mapper;
        ResultModel resultModel = new ResultModel();
        public TosubmitController(TosubmitRepository tosubmitRepository, IMapper mapper)
        {
            _tosubmitRepository = tosubmitRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListAjax()
        {
            var tosubmits = await _tosubmitRepository.GetAllAsync();
            var tosubmitModels = _mapper.Map<List<TosubmitModel>>(tosubmits);
            return Json(tosubmitModels);
        }

        public async Task<IActionResult> GetByIdAjax(int id)
        {
            var tosubmit = await _tosubmitRepository.GetByIdAsync(id);
            var tosubmitModel = _mapper.Map<TosubmitModel>(tosubmit);
            return Json(tosubmitModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddUpdateAjax(TosubmitModel model)
        {
            if (model.Id == 0)
            {
                var tosubmit = new Tosubmit();
                tosubmit.Title = model.Title;
                tosubmit.Description = model.Description;
                tosubmit.IsOK = model.IsOK;
                tosubmit.IsActive = true;
                tosubmit.Created = DateTime.Now;
                tosubmit.Updated = DateTime.Now;
                await _tosubmitRepository.AddAsync(tosubmit);
                resultModel.Status = true;
                resultModel.Message = "Ödev Teslim Durumu Eklendi";
            }
            else
            {
                var tosubmit = await _tosubmitRepository.GetByIdAsync(model.Id);
                if (tosubmit == null)
                {
                    resultModel.Status = false;
                    resultModel.Message = "Ödev Bulunamadı!";
                    return Json(resultModel);
                }
                tosubmit.Title = model.Title;
                tosubmit.Description = model.Description;
                tosubmit.IsOK = model.IsOK;
                tosubmit.Updated = DateTime.Now;
                await _tosubmitRepository.UpdateAsync(tosubmit);
                resultModel.Status = true;
                resultModel.Message = "Ödev Teslim Durumu Düzenlendi";
            }

            return Json(resultModel);
        }

        public async Task<IActionResult> DeleteAjax(int id)
        {
            var tosubmit = await _tosubmitRepository.GetByIdAsync(id);
            if (tosubmit == null)
            {
                resultModel.Status = false;
                resultModel.Message = "Ödev Bulunamadı!";
                return Json(resultModel);
            }
            await _tosubmitRepository.DeleteAsync(id);
            resultModel.Status = true;
            resultModel.Message = "Ödev Silindi";
            return Json(resultModel);
        }
    }
}

