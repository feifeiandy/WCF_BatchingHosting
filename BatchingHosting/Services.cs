using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Artech.BatchingHosting
{
    [ServiceContract(Namespace = "http://www.artech.com")]
    public interface IFoo
    {
        [OperationContract]
        void Doth();
    }

    [ServiceContract(Namespace = "http://www.artech.com")]
    public interface IBar
    {
        [OperationContract]
        void Doth2();
    }

    [ServiceContract(Namespace = "http://www.artech.com")]
    public interface IBaz
    {
        [OperationContract]
        void Doth();
    }

    public class FooService : IFoo,IBar
    {
        public void Doth() { }
        public void Doth2() { }
    }

    public class BarService : IBar
    {
        public void Doth2() { }
    }

    public class BazService : IBaz
    {
        public void Doth() { }
    }
    
}
