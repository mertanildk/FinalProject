﻿using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Core.Extensions.ErrorDetails;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            httpContext.Response.ContentType = "application/json";//tarayıcımıza 1 tane json gönderiyoruz demektir.
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;//gönderilen hata kodu.

            string message = "Internal Server Error";
            IEnumerable<ValidationFailure> errors;
            if (e.GetType() == typeof(ValidationException))
            {
                message = e.Message;
                errors = ((ValidationException) e).Errors;
                httpContext.Response.StatusCode = 400;//badrequest
                return httpContext.Response.WriteAsync(new ValidationErrorDetails
                {
                    StatusCode =400,
                    Message=message,
                    Errors=errors

                }.ToString());//validation hatası alırsak bu method çalışsın
            }

            return httpContext.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = httpContext.Response.StatusCode,
                Message = message
            }.ToString());//SİSTEM HATA VERİRSE BUNU DÖNDÜR //olur da sistemsel hata varsa  burası çalışsın.

        }
    }
}
