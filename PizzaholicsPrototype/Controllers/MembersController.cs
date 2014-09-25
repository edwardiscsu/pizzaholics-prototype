using AttributeRouting.Web.Http;
using PizzaholicsPrototype.Models.Models;
using PizzaholicsPrototype.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaholicsPrototype.Controllers
{
    public class MembersController : ApiController
    {
        private IMembersRepository MembersRepository { get; set; }

        public MembersController(IMembersRepository membersRepository)
        {
            this.MembersRepository = membersRepository;
        }


        [GET("api/members/{memberNumber}")]
        public Member GetMember(int memberNumber)
        {
            var member = new Member();

            try
            {
                //TODO
            }
            catch (Exception e)
            {
                var responseMessage = new HttpResponseMessage(HttpStatusCode.BadRequest); 
                responseMessage.ReasonPhrase = e.Message;
                throw new HttpResponseException(responseMessage);
            }

            return member;
        }

        [POST("api/members/")]
        public void PostMember([FromBody]Member newMember)
        {
            try
            {
                //TODO
            }
            catch (Exception e)
            {
                var responseMessage = new HttpResponseMessage(HttpStatusCode.BadRequest);
                responseMessage.ReasonPhrase = e.Message;
                throw new HttpResponseException(responseMessage);
            }
        }

        [PUT("api/members/{memberNumber}")]
        public void PutMember(int memberNumber, [FromBody]Member updatedMember)
        {
            try
            {
                //TODO
            }
            catch (Exception e)
            {
                var responseMessage = new HttpResponseMessage(HttpStatusCode.BadRequest);
                responseMessage.ReasonPhrase = e.Message;
                throw new HttpResponseException(responseMessage);
            }
        }
    }
}