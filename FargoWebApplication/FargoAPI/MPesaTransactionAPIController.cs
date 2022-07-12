using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fargo_DataAccessLayers;
using FargoWebApplication.Filter;
using Fargo_Application.App_Start;
using Fargo_Models;
using FargoWebApplication.Manager;
using System.Threading;

namespace FargoWebApplication.FargoAPI
{
    [BasicAuthentication]
    public class MPesaTransactionAPIController : ApiController
    {
        [HttpPost]
        [Route("api/MPesaTransactionAPI/MPesaTransactionRequest")]
        public HttpResponseMessage MPesaTransactionRequest([FromBody] MPesaTransactionModel mPesaTransactionModel)
        {

            try
            {
                ResponseModel responseModel = new ResponseModel();
                string Username = Thread.CurrentPrincipal.Identity.Name;
                if (!string.IsNullOrEmpty(Username))
                {
                    //int result = MPesaTransactionManager.MPesaTransactionRequest(mPesaTransactionModel);
                    //if (result > 0)
                    //{
                    //    if (mPesaTransactionModel.ResultDesc.ToLower().Contains("success"))
                    //    {
                    //        responseModel.Status = "Success";
                    //        responseModel.Message = "Transaction successfully made.";
                    //        responseModel.Description = "The service request is processed successfully.";
                    //        return Request.CreateResponse(HttpStatusCode.Created, responseModel);
                    //    }
                    //    else
                    //    {
                    //        responseModel.Status = "Failed";
                    //        responseModel.Message = "Transaction not made.";
                    //        responseModel.Description = "The service request is not processed.";
                    //        return Request.CreateResponse(HttpStatusCode.InternalServerError, responseModel);
                    //    }                       
                    //}
                    //else
                    //{
                    //    responseModel.Status = "Failed";
                    //    responseModel.Message = "Transaction not made.";
                    //    responseModel.Description = "The service request is not processed.";
                    //    return Request.CreateResponse(HttpStatusCode.InternalServerError, responseModel);
                    //}
                    if (!string.IsNullOrEmpty(mPesaTransactionModel.ResultDesc) && mPesaTransactionModel.ResultDesc.ToLower().Contains("success"))
                    {
                        responseModel.Status = "Success";
                        responseModel.Message = "Transaction successfully made.";
                        responseModel.Description = "The service request is processed successfully.";
                        return Request.CreateResponse(HttpStatusCode.Created, responseModel);
                    }
                    else
                    {
                        responseModel.Status = "Failed";
                        responseModel.Message = "Transaction not made.";
                        responseModel.Description = "The service request is not processed.";
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, responseModel);
                    } 
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new Exception("Unauthorized, Please try again."));
                }
            }
            catch (Exception exception)
            {
                ExceptionLogging.SendErrorToText(exception);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exception.Message.ToString());
            }
        }
    }
}
