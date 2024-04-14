using MicrosAccounting.Api.Models.Categories;
using MicrosAccounting.Api.Models.Orchestration;
using MicrosAccounting.Api.Services.Orchestration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MicrosAccounting.Api.Controllers;
//[Authorize]
[ApiController]
[Route("api[controller]")]
public class TransactionResultController : ControllerBase
{
    private readonly ITransactionResultService transactionResultService;

    public TransactionResultController(ITransactionResultService transactionResultService)
    {
        this.transactionResultService = transactionResultService;
    }

    [HttpGet]
    public ActionResult<IQueryable<TransactionResult>> GetAllTransactionResults()
    {
        var result = transactionResultService.RetrieveAllTransactionResult();
        
        return Ok(result);
    }

    [HttpGet("type/{type}")]
    public ActionResult<IQueryable<TransactionResult>> GetAllTransactionResultsByType(CategoryAccount type)
    {
        var result = transactionResultService.RetrieveTransactionResultByAccounting(type);
        
        return Ok(result);
    }

    [HttpGet("date/{datetime}")]
    public ActionResult<IQueryable<TransactionResult>> GetAllTransactionResultsByDate(DateTime datetime)
    {
        var result = transactionResultService.RetrieveTransactionResultByDate(datetime);
        
        return Ok(result);
    }

    [HttpGet("between/date")]
    public ActionResult<IQueryable<TransactionResult>>
        GetAllTransactionResultsBetweenDates(DateTime startDate, DateTime endDate)
    {
        var result = 
            transactionResultService.RetrieveTransactionResultBetweenDate(startDate, endDate);
        
        return Ok(result);
    }

    [HttpGet("names")]
    public ActionResult<IQueryable<TransactionResult>> 
        GetAllTransactionResultsByName([FromQuery]IEnumerable<string> name)
    {
        var result = transactionResultService.RetrieveTransactionResultByName(name);
        
        return Ok(result);
    }
}