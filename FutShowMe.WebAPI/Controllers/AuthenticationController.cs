using Amazon;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using FutShowMe.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutShowMe.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private const string _clientId = "3258n8r46oeoscga2jejkbju3g";
        private readonly RegionEndpoint _region = RegionEndpoint.USWest2;

        [HttpPost]
        [Route("Cadastrar")]
        public async Task<ActionResult<string>> Cadastrar(UserViewModel user)
        {
            var cognito = new AmazonCognitoIdentityProviderClient(new Amazon.Runtime.AnonymousAWSCredentials(), _region);

            var request = new SignUpRequest
            {
                ClientId = _clientId,
                Password = user.Password,
                Username = user.Username
            };

            var emailAttribute = new AttributeType
            {
                Name = "email",
                Value = user.Email
            };
            request.UserAttributes.Add(emailAttribute);

            var response = await cognito.SignUpAsync(request);

            return Ok();
        }

        [HttpPost]
        [Route("GetToken")]
        public async Task<ActionResult<string>> GetToken(UserViewModel user)
        {
            var awsCredentials = new Amazon.Runtime.BasicAWSCredentials("AKIAJ7BOWC5RMJ7TVMDQ", "MiCAGAw1PbBuaBKNEFSM7PP+UErR6U0N8Lrq3j/r");
            var cognito = new AmazonCognitoIdentityProviderClient(awsCredentials, _region);

            var request = new AdminInitiateAuthRequest
            {
                UserPoolId = "us-west-2_8RxRlJIxy",
                ClientId = _clientId,
                AuthFlow = AuthFlowType.ADMIN_NO_SRP_AUTH
            };

            request.AuthParameters.Add("USERNAME", user.Username);
            request.AuthParameters.Add("PASSWORD", user.Password);


            var response = await cognito.AdminInitiateAuthAsync(request);

            return Ok(response.AuthenticationResult.IdToken);

        }
    }
}

