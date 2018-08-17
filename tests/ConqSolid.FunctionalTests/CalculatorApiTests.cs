using ConqSolid.Web;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using ConqSolid.MessageTypes;
using ConqSolid.Common;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Moq;
using System;

public class CalculatorApiTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;
    public CalculatorApiTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }
    
    [Fact]
    public async Task AdderMustAdd()
    {
        var testData = new CalculatorRequest
        {
            CalculatorOperatorType = CalculatorOperatorTypeEnum.Adder,
            LeftVal = 3,
            RightVal = 6
        };
        int addingResult = await getResultAsync(testData);
        Assert.Equal(9, addingResult);
    }

    [Fact]
    public async Task SubstracterMustSubstract()
    {
        var testData = new CalculatorRequest
        {
            CalculatorOperatorType = CalculatorOperatorTypeEnum.Substracter,
            LeftVal = 123,
            RightVal = 43
        };
        int substractResult = await getResultAsync(testData);
        Assert.Equal(80, substractResult);
    }

    [Fact]
    public async Task MultiplierMustMultiply()
    {
        var testData = new CalculatorRequest
        {
            CalculatorOperatorType = CalculatorOperatorTypeEnum.Multiplier,
            LeftVal = 84,
            RightVal = 37
        };
        int multiplyResult = await getResultAsync(testData);
        Assert.Equal(3108, multiplyResult);
    }

    [Fact]
    public async Task DividerMustDivide()
    {
        var testData = new CalculatorRequest
        {
            CalculatorOperatorType = CalculatorOperatorTypeEnum.Divider,
            LeftVal = 84,
            RightVal = 14
        };
        int multiplyResult = await getResultAsync(testData);
        Assert.Equal(6, multiplyResult);
    }

    [Fact]
    public async Task UndefinedMustReturnBadRequest()
    {
        var random = new Random();
        var calculatorRequest = new CalculatorRequest
        {
            CalculatorOperatorType = CalculatorOperatorTypeEnum.Undefined,
            LeftVal = random.Next(100),
            RightVal = random.Next(100)
        };

        var testDataContent = JsonConvert.SerializeObject(calculatorRequest);
        var testDataStringContent = new StringContent(testDataContent, System.Text.Encoding.UTF8, "application/json");
        var response = await _client.PostAsync("/api/calculator", testDataStringContent);
        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    private async Task<int> getResultAsync(CalculatorRequest calculatorRequest)
    {
        var testDataContent = JsonConvert.SerializeObject(calculatorRequest);
        var testDataStringContent = new StringContent(testDataContent, System.Text.Encoding.UTF8, "application/json");
        var response = await _client.PostAsync("/api/calculator", testDataStringContent);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();
        var calculatorResponse = JsonConvert.DeserializeObject<CalculatorResponse>(responseString);
        return calculatorResponse.Result;

    }

}