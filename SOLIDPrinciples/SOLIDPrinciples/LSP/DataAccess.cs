using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples.LSP
{
    class DataAccess
    {
        public void SaveEntity(IEntity entity)
        {
            // Code here is refering to SUB classes and not BASE CLASS IEntity
            if ((entity as WidgetEntity) != null)
            {
                GenerateWidgetAuditEntry((WidgetEntity)entity);
            }
            if ((entity as ChocolateEntity) != null)
            {
                GenerateChocolateAuditEntry((ChocolateEntity)entity);
            }
            // ...
            ApprovalEntity approval = entity as ApprovalEntity;
            if (approval != null && approval.Level < 2)
            {
                throw new RequiresApprovalException(approval);
            }
            //  Code here is refering to SUB classes and not BASE CLASS IEntity

            DateTime saveDate = DateTime.Now;

            if (entity.IsNew)
                entity.CreatedDate = saveDate;
            entity.UpdatedDate = saveDate;
            DBConnection.Save(entity);
        }

    }
}
