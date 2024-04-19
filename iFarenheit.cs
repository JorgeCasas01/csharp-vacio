using System;
using System.ServiceModel;

namespace iFarenheit{
    [ServiceContract]
    public interface iFarenheit{
        [OperationContract]
        double tempf (double tempf);
        double tempc (double tempc);
    }
}