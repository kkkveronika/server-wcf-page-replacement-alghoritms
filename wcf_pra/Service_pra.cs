using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using fifolru_algo_lib;

namespace wcf_pra
{
    [ServiceBehavior(InstanceContextMode =InstanceContextMode.PerSession)]
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service_pra : IService_pra
    {

        public void algorithm_fifo4(List<int> row_page, List<int> fifo4, List<string> fifo5, List<int> lru4, List<string> lru5)
        {
            List<string> result_fifo4 = new List<string>();
            result_fifo4=Class1.fifo4(row_page, fifo4, 0);
            List<string> result_fifo5 = new List<string>();
            result_fifo5 = Class1.fifo5(row_page, fifo5, 0);
            List<string> result_lru4 = new List<string>();
            result_lru4 = Class1.lru4(row_page, lru4, 0);
            List<string> result_lru5 = new List<string>();
            result_lru5 = Class1.lru5(row_page, lru5, 0);

            Server_user user = new Server_user()
            {
                operation_context=OperationContext.Current
            };
            user.operation_context.GetCallbackChannel<Iservice_pra_callback>().fifo4_callback(result_fifo4, result_fifo5, result_lru4, result_lru5);

        }
    }
}
