using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using App.WinForm.Attributes;
using LinqExtension;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using App.WinForm;
using System.Data.Entity.Validation;
using App.WinForm.Entities;
using App.WinForm.Application.Presentation.Messages;
using App.WinForm.Application.BAL;

namespace App
{
    public class BaseRepository<T> : GenericWinAppBaseRepository<T> ,IBaseRepository where T : BaseEntity
    {
     
        #region construcreur
        public BaseRepository(DbContext context)
        {
            this.context = (ModelContext) context;
            if (this.context == null) this.context = new ModelContext();

            this.DbSet = this.context.Set<T>();
            this.TypeEntity = typeof(T);
        }
        public BaseRepository() : this(null) { }
        #endregion

        #region Context

       // public override ModelContext context { get; set; }

        DbContext IBaseRepository.Context()
        {
            return this.context;
        }

        public override void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }
        #endregion



        #region CreateInstance
        public override object CreateInstanceObjet()
        {
            return this.context.Set<T>().Create();
        }

        /// <summary>
        /// Creating an instance of the Service object from the entity type
        /// </summary>
        /// <param name="TypeEntity">the entity type</param>
        /// <returns></returns>
        public override IBaseRepository CreateInstance_Of_Service_From_TypeEntity(Type TypeEntity)
        {

            Type TypeEntityService = typeof(BaseRepository<>).MakeGenericType(TypeEntity);
            IBaseRepository EntityService = (IBaseRepository)Activator.CreateInstance(TypeEntityService, this.context);
            return EntityService;
        }
        /// <summary>
        /// Creating an instance of the Service object from the entity type and Context
        /// </summary>
        /// <param name="TypeEntity">the entity type</param>
        /// <param name="context">the context</param>
        /// <returns></returns>
        public virtual IBaseRepository CreateInstance_Of_Service_From_TypeEntity(Type TypeEntity, DbContext context)
        {

            Type TypeEntityService = typeof(BaseRepository<>).MakeGenericType(TypeEntity);
            IBaseRepository EntityService = (IBaseRepository)Activator.CreateInstance(TypeEntityService, context);
            return EntityService;
        }
        #endregion


    }
}
