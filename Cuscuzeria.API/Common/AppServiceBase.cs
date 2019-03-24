using Cuscuzeria.API.Interface;
using Cuscuzeria.Domain.Services;
using System;
using System.Collections.Generic;

namespace Cuscuzeria.API
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private IUserService userService;
        private IOrderAppService orderService;

        public AppServiceBase(IUserService userService)
        {
            this.userService = userService;
            this.orderService = orderService;
        }

        public AppServiceBase(IOrderAppService orderService)
        {
            this.orderService = orderService;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        void IAppServiceBase<TEntity>.Dispose()
        {
            _serviceBase.Dispose();
        }

        void IDisposable.Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}