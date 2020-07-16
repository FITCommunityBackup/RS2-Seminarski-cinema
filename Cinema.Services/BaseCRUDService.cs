﻿using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(IUnitOfWork unit,IMapper mapper) : base(unit,mapper)
        {
        }

        public virtual TModel Insert(TInsert req)
        {
            var entity = _mapper.Map<TDatabase>(req);

            _repo.InsertAsync(entity);
            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }

        public async virtual Task<TModel> Update(int id, TUpdate req)
        {
            var entity = await _repo.GetAsync(id);

            await _repo.UpdateAsync(entity,id);

            _mapper.Map(req, entity);

            _unit.Save();

            return _mapper.Map<TModel>(entity);
        }
    }
}