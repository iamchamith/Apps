using ECart.DbAccess;
using ECart.Domain.Models;
using ECart.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECart.Bo.Utility.Enums;

namespace One.DbService.Infrastructure
{
    public interface IUnitOfWork
    {
        GenericRepository<Item> ItemRepository { get; }
        GenericRepository<User> UserRepository { get; }
        GenericRepository<Checkout> CheckoutRepository { get; }
        GenericRepository<CheckoutSummery> CheckoutSummeryRepository { get; }
        GenericRepository<Error> ErrorRepository { get; }
        void Save();
        Task SaveAsync();
        ECartContext Context { get; }

    }
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork()
        {
            context = new ECartContext();
        }
        public UnitOfWork(IEcartContext cnt, AppRunTime type)
        {
            if (type == AppRunTime.Debug)
            {
                context = (ECartContext)cnt;
                context.Configuration.AutoDetectChangesEnabled = false;
            }
            else
            {
                context = (ECartContext)cnt;
            }
        }
        private DbContext context;
        private GenericRepository<Item> itemRepository;
        private GenericRepository<User> userRepository;
        private GenericRepository<Checkout> checkoutRepository;
        private GenericRepository<CheckoutSummery> checkoutSummeryRepository;
        private GenericRepository<Error> errorRepository;
        public ECartContext Context
        {
            get
            {
                return context as ECartContext;
            }
        }
        public GenericRepository<Item> ItemRepository
        {
            get
            {
                if (this.itemRepository == null)
                {
                    this.itemRepository = new GenericRepository<Item>(context);
                }
                return itemRepository;
            }
        }
        public GenericRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(context);
                }
                return userRepository;
            }
        }
        public GenericRepository<Checkout> CheckoutRepository
        {
            get
            {
                if (this.checkoutRepository == null)
                {
                    this.checkoutRepository = new GenericRepository<Checkout>(context);
                }
                return checkoutRepository;
            }
        }
        public GenericRepository<CheckoutSummery> CheckoutSummeryRepository
        {
            get
            {
                if (this.checkoutSummeryRepository == null)
                {
                    this.checkoutSummeryRepository = new GenericRepository<CheckoutSummery>(context);
                }
                return checkoutSummeryRepository;
            }
        }
        GenericRepository<Error> IUnitOfWork.ErrorRepository
        {
            get
            {
                if (this.errorRepository == null)
                {
                    this.errorRepository = new GenericRepository<Error>(context);
                }
                return errorRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}