/*Madeline Gowan
10-25-2022
Add Two Numbers - Endpoint
In this we will add two numbers, now in a way that is compatible with postman

Peer review: Ulises Ortega, the code is clean works as expected, I test it in ost man and it ouput the addition of the numbers, good Job!

*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMAddTwoNumbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MathStuffsController : ControllerBase
{

//cheat sheet: https://localhost:xxxx/MathStuffs/Adding/x/x

    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
}