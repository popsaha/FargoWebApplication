using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fargo_Models
{
    public class MPesaTransactionModel
    {
        public string MerchantRequestID { get; set; }
        public string CheckoutRequestID { get; set; }
        public string ResultCode { get; set; }
        public string ResultDesc { get; set; }
        public string USER_ID { get; set; }
        public List<CallbackMetadata> CallbackMetadata { get; set; }
    }

    public class CallbackMetadata
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
