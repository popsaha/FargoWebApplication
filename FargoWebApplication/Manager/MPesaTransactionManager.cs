using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Fargo_DataAccessLayers;
using Fargo_Models;
using Fargo_Application.App_Start;
using FargoWebApplication.Filter;

namespace FargoWebApplication.Manager
{
    public class MPesaTransactionManager
    {
        public static int MPesaTransactionRequest(MPesaTransactionModel mPesaTransactionModel)
        {
            int result = 0;
            try
            {
                SqlParameter sp1 = new SqlParameter("@MerchantRequestID", mPesaTransactionModel.MerchantRequestID);
                SqlParameter sp2 = new SqlParameter("@CheckoutRequestID", mPesaTransactionModel.CheckoutRequestID);
                SqlParameter sp3 = new SqlParameter("@ResultCode", mPesaTransactionModel.ResultCode);
                SqlParameter sp4 = new SqlParameter("@ResultDesc", mPesaTransactionModel.ResultDesc);
                SqlParameter sp5 = new SqlParameter("@CallbackMetadata", mPesaTransactionModel.CallbackMetadata);
                SqlParameter sp6 = new SqlParameter("@USER_ID", mPesaTransactionModel.USER_ID);
                SqlParameter sp7 = new SqlParameter("@CREATED_ON", DateTime.Now);
                SqlParameter sp8 = new SqlParameter("@FLAG", "1");
                result = clsDataAccess.ExecuteNonQuery(CommandType.StoredProcedure, "spMPesaTransaction", sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8);
            }
            catch (Exception exception)
            {
                string ErrorMessage = ExceptionLogging.SendErrorToText(exception);
            }
            return result;
        }
    }
}