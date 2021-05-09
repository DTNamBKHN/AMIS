using MISA.DL;
using System;
using System.Collections.Generic;

namespace MISA.BL
{
    public class BaseBL
    {

        public IEnumerable<MISAEntity> GetAll<MISAEntity>()
        {
            BaseDL baseDL = new BaseDL();
            return baseDL.GetAll<MISAEntity>();
        }

        public MISAEntity GetById<MISAEntity>(Guid entityId)
        {
            BaseDL baseDL = new BaseDL();
            return baseDL.GetById<MISAEntity>(entityId);
        }

        public int Insert<MISAEntity>(MISAEntity entity)
        {
            // validate dữ liệu:
            Validate<MISAEntity>(entity);
            BaseDL baseDL = new BaseDL();
            return baseDL.Insert<MISAEntity>(entity);
        }

        public int Update<MISAEntity>(MISAEntity entity, Guid entityId)
        {
            BaseDL baseDL = new BaseDL();
            return baseDL.Update<MISAEntity>(entity, entityId);
        }

        public int Delete<MISAEntity>(Guid entityId)
        {
            BaseDL baseDL = new BaseDL();
            return baseDL.Delete<MISAEntity>(entityId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="MISAEntity"></typeparam>
        /// <param name="entity"></param>
        protected virtual void Validate<MISAEntity>( MISAEntity entity)
        {

        }
    }
}
