using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.WebInfo.Entities.Concrete
{
    public class EntitiyBase : IEntity
    {
        public long? CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        public long? LastModified { get; set; }


        public DateTime? LastModifiedDate { get; set; }

        [DefaultValue(false)]
        public bool IsState { get; set; }

        [DefaultValue(false)]
        public bool IsDelete { get; set; }
    }
}
