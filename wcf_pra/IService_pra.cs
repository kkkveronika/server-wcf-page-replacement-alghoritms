using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_pra
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(CallbackContract =typeof(Iservice_pra_callback))]
    public interface IService_pra
    {
        [OperationContract(IsOneWay=true)]
        void algorithm_fifo4(List<int> row_page, List<int> fifo4, List<string> fifo5, List<int> lru4, List<string> lru5);
    }

    public interface Iservice_pra_callback
    {
        [OperationContract(IsOneWay =true)]

        void fifo4_callback(List<string> result_fifo4, List<string> result_fifo5, List<string> result_lru4, List<string> result_lru5);
    }
}
