﻿using AutoMapper;
using Cinema.Common.Interfaces.Dal;
using Cinema.Common.Interfaces.Services;
using Cinema.Models.Requests;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate>
        where TDatabase : class
        where TSearch : BaseSearchRequest
    {
        public BaseCRUDService(IUnitOfWork unit, IMapper mapper) : base(unit, mapper)
        {
        }

        public virtual async Task<TModel> InsertAsync(TInsert req)
        {
            var entity = _mapper.Map<TDatabase>(req);

            await _repo.InsertAsync(entity);
            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }

        public async virtual Task<TModel> UpdateAsync(int id, TUpdate req)
        {
            var entity = await _repo.GetAsync(id);

            await _repo.UpdateAsync(entity, id);

            _mapper.Map(req, entity);

            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }


        public virtual async Task<bool> DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            _unit.Save();

            return true;
        }
    }
}
