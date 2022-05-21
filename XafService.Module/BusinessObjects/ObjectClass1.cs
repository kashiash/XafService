using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafService.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class ObjectClass1 : BaseObject
    {
        public ObjectClass1(Session session) : base(session)
        { }


        DateTime date;
        string text;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Text
        {
            get => text;
            set => SetPropertyValue(nameof(Text), ref text, value);
        }
        
        public DateTime Date
        {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }
    }
}
