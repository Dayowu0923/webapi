using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using AutoMapper;
using WebApplication13.Dtos;
using Microsoft.EntityFrameworkCore;
namespace WebApplication13.Services
{
    public interface ICog1Service
    {
        Task<IActionResult> Get();
        Task<IActionResult> Get(int id);
        Task<IActionResult> Post(TbItemTypeDto value);
        Task<IActionResult> Put(int id, TbItemTypeDto value);
        Task<IActionResult> Delete(int id);
    }
    public class Cog1Service : ICog1Service
    {
        private readonly _2023gtafContext _gtafContext;
        private readonly IMapper _imapper;
        private readonly IJwtToken _auth;

        public Cog1Service(_2023gtafContext gtafContext, IMapper imapper, IJwtToken auth)
        {
            _gtafContext = gtafContext;
            _imapper = imapper;
            _auth = auth;
        }
        public async Task<IActionResult> Get()
        {
            var item = await (from tbl in _gtafContext.TbItemTypes
                              where tbl.Status == true
                              select new
                              {
                                  Id = tbl.Id,
                                  No = tbl.No,
                                  Name = tbl.Name,
                                  Udate = tbl.Udate.HasValue ? tbl.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                                  Uuser = tbl.Uuser,
                              }
                     ).ToListAsync();
            return new OkObjectResult(item);
        }

        public async Task<IActionResult> Get(int id)
        {
            var item = await (from tbl in _gtafContext.TbItemTypes
                              where tbl.Status == true && tbl.Id == id
                              select new
                              {
                                  Id = tbl.Id,
                                  No = tbl.No,
                                  Name = tbl.Name,
                                  Udate = tbl.Udate.HasValue ? tbl.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                                  Uuser = tbl.Uuser,
                              }
                   ).FirstOrDefaultAsync();

            if (item == null)
            {
                return new NotFoundObjectResult("找不到資料");
            }
            return new OkObjectResult(item);
        }


        public async Task<IActionResult> Post(TbItemTypeDto value)
        {

            string user = _auth.GetUser();
            TbItemType entity = _imapper.Map<TbItemType>(value);
            entity.Cuser = user;
            entity.Uuser = user;
            _gtafContext.TbItemTypes.Add(entity);
            await _gtafContext.SaveChangesAsync();
            return  new OkResult();
        }
        public async Task<IActionResult> Put(int id,TbItemTypeDto value)
        {
            string user = _auth.GetUser();
            if (id != value.Id)
            {
                return new BadRequestObjectResult("找不到資料");
            }
            var item = await _gtafContext.TbItemTypes.FindAsync(id);
            if (item == null)
            {
                return new BadRequestObjectResult("找不到資料");
            }
            item.Udate = DateTime.Now;
            item.Uuser = user;
            item.Name = value.Name;
            item.No = value.No;
            await _gtafContext.SaveChangesAsync();
            return new NoContentResult();
        }
        public async Task<IActionResult> Delete(int id)
        {
            bool item_sub = await _gtafContext.TbItemCodes.AnyAsync(item => item.ItemTypeid == id);
            if (item_sub)
            {
                return new BadRequestObjectResult("底下有資料");
            }
            var item = await _gtafContext.TbItemTypes.FindAsync(id);
            if (item == null)
            {
                return new BadRequestObjectResult("找不到資料");
            }
            item.Status = false;
            await _gtafContext.SaveChangesAsync();
            return new NoContentResult();
        }
    }
}
