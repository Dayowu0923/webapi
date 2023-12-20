using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication13.Dtos;
using WebApplication13.Models;

namespace WebApplication13.Services
{
    public class CogItemService
    {
        private readonly _2023gtafContext _gtafContext;
        private readonly IMapper _imapper;
        private readonly JwtToken _auth;

        public CogItemService(_2023gtafContext gtafContext, IMapper imapper, JwtToken auth)
        {
            _gtafContext = gtafContext;
            _imapper = imapper;
            _auth = auth;
        }

        public async Task<IActionResult> Get()
        {
            var item = await (from tbl in _gtafContext.TbItemCodes
                              join tbm in _gtafContext.TbItemTypes on tbl.ItemTypeid equals tbm.Id
                              where tbl.ActiveFlag == true
                              orderby tbm.Id
                              select new
                              {
                                  Mid = tbm.Id,
                                  Id = tbl.Id,
                                  Mname = tbm.Name,
                                  No = tbl.ItemNo,
                                  Name = tbl.ItemName,
                                  Udate = tbl.Udate.HasValue ? tbl.Udate.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                                  Uuser = tbl.Uuser,
                              }
                     ).ToListAsync();
            return new OkObjectResult(item);
        }

        public async Task<IActionResult> Get(int id)
        {
            var item = await (from tbl in _gtafContext.TbItemCodes
                              join tbm in _gtafContext.TbItemTypes on tbl.ItemTypeid equals tbm.Id
                              where tbl.ActiveFlag == true && tbl.Id == id
                              orderby tbm.Id
                              select new
                              {
                                  Mid = tbm.Id,
                                  Id = tbl.Id,
                                  Mname = tbm.Name,
                                  No = tbl.ItemNo,
                                  Name = tbl.ItemName,
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


        public async Task<IActionResult> Post(TbItemCodeDto value)
        {
            string user = _auth.GetUser();
            TbItemCode entity = _imapper.Map<TbItemCode>(value);
            entity.Cuser = user;
            entity.Uuser = user;
            _gtafContext.TbItemCodes.Add(entity);
            await _gtafContext.SaveChangesAsync();
            return new OkResult();
        }

      
        public async Task<IActionResult> Put(int id,TbItemCodeDto value)
        {
            string user = _auth.GetUser();
            if (id != value.Id)
            {
                return new BadRequestObjectResult("ID不正確");
            }
            var item = await _gtafContext.TbItemCodes.FindAsync(id);
            if (item == null)
            {
                return new NotFoundObjectResult("找不到資料");
            }
            item.Udate = DateTime.Now;
            item.Uuser = user;
            item.ItemName = value.Item_name;
            item.ItemNo = value.Item_no;
            item.ItemTypeid = value.Mid;
            await _gtafContext.SaveChangesAsync();
            return new NoContentResult();
        }
      
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _gtafContext.TbItemCodes.FindAsync(id);
            if (item == null)
            {
                return new NotFoundObjectResult("找不到資料");
            }
            item.ActiveFlag = false;
            await _gtafContext.SaveChangesAsync();
            return new NoContentResult();
        }
    }
}
