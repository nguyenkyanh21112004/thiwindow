using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using DTO;
namespace CSDL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IThaotacCSDL" in both code and config file together.
    [ServiceContract]
    public interface IThaotacCSDL
    {
        [OperationContract]
        void Insert(Lop lop);
        [OperationContract]
        void Update(Lop lop);
        [OperationContract]
        void Delete(Lop lop);
        [OperationContract]
        List<Lop> Load();
    }
}
