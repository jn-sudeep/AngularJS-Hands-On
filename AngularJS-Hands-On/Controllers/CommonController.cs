using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;

namespace AngularJS.HandsOn.Controllers
{
    public class CommonController : ApiController
    {
        //public HttpResponseMessage GetBooks()
        //{
        //    HttpResponseMessage response = new HttpResponseMessage();

        //    try
        //    {
        //        LibraryRepository libraryRepository = new LibraryRepository(Constants.ConnectionString);
        //        response.StatusCode = HttpStatusCode.OK;
        //        response.Content = new ObjectContent(typeof(List<Book>), libraryRepository.GetBooks(), GlobalConfiguration.Configuration.Formatters.JsonFormatter);
        //        return response;                        
        //    }
        //    catch (DataDuplicityException ex)
        //    {
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //        response.Content = new StringContent(ex.ErrorMessage);
        //        return response;
        //    }
        //    catch (DataLayerException ex)
        //    {
        //        response.StatusCode = HttpStatusCode.InternalServerError;
        //        response.Content = new StringContent(ex.ErrorMessage);
        //        return response;
        //    }
        //}

    }
}