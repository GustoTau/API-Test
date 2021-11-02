using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using RestSharpFramework.Helpers;
using RestSharpFramework.Objects;
using System;
using TechTalk.SpecFlow;

namespace RestSharpFramework.Step_Definitions
{
    [Binding]
    public class DogSteps
    {
        private RestClient client;
        private RestRequest request;
        private IRestResponse response;

        [Given(@"user sends a GET request to search for random breeds")]
        public void GivenUserSearchesForRandomBreeds()
        {
            client = new RestClient(Data.DogAPIRandomSearchURL);
            request = new RestRequest(Method.GET);
        }
        [Then(@"user should recieve a message with status ""(.*)""")]
        public void ThenUserShouldRecieveAMessageWithStatus(string status)
        {
            response = client.Execute(request);
            DogObject searchresponse = new JsonDeserializer().Deserialize<DogObject>(response);
            Assert.AreEqual(status, searchresponse.status, "status is not correct");
        }
        [Given(@"user sends a GET Request to search for list of all breeds")]
        public void GivenUserSearchesForListOfAllBreeds()
        {
            client = new RestClient(Data.DogAPIBreedListURL);
            request = new RestRequest(Method.GET);
        }

        [Then(@"check that ""(.*)"" does exist in the list")]
        public void ThenCheckThatDoesExistInTheList(string breed)
        {
            response = client.Execute(request);
            if(!response.Content.Contains(breed))
            {
                Assert.Fail(breed +": Not found on list");
            }
        }
        [Given(@"user sends a GET request to search for list of all sub breeds for bulldog and their images")]
        public void GivenUserSearchesForListOfAllSubBreedsForBulldogAndTheirImages()
        {
            client = new RestClient(Data.DogAPIBulldogSearch);
            request = new RestRequest(Method.GET);
        }

        [Then(@"the message should contain ""(.*)""")]
        public void ThenTheMessageShouldContain(string images)
        {
            response = client.Execute(request);
            if (!response.Content.Contains(images))
            {
                Assert.Fail(images + ": Not found on list");
            }
        }
    }
}
