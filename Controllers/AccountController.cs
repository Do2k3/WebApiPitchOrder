using Microsoft.AspNetCore.Mvc;
using TestApiPitchOrder.Data;
using TestApiPitchOrder.Models;
using TestApiPitchOrder.Services;

namespace TestApiPitchOrder.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : BaseController<Account>
    {
        private readonly IAccountService _accountService;
        private readonly PitchOrderDbContext _context;

        public AccountController(IAccountService accountService, PitchOrderDbContext context) : base(accountService)
        {
            _accountService = accountService;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var accounts = await _accountService.GetAccounts();
            return Ok(accounts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id)
        {
            var account = await _accountService.GetAccountById(id);
            if (account != null)
            {
                return Ok(account);
            }
            return NotFound();
        }

        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetAccountByName(string name)
        {
            var account = await _accountService.GetAccountByName(name);
            if (account != null)
            {
                return Ok(account);
            }
            return NotFound();
        }

        [HttpGet("byemail/{email}")]
        public async Task<IActionResult> GetByEmailAsync(string email)
        {
            try
            {
                var account = await _accountService.GetByEmailAsync(email);
                if (account != null)
                {
                    return Ok(account);
                }
                return NotFound();
            }
            catch (InvalidOperationException ex)
            {
                // Ghi lại lỗi và trả về thông báo phù hợp
                return BadRequest(new { message = "Multiple accounts with the same email were found." });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAccount(Account account)
        {
            if (account == null || string.IsNullOrEmpty(account.Password))
            {
                return BadRequest("Invalid account data.");
            }

            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            await _accountService.AddAccount(account);
            return Ok("Account added successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAccount([FromBody] Account account)
        {
            if (account == null || account.Id == 0)
            {
                return BadRequest("Invalid account data.");
            }

            var existingAccount = await _context.Accounts.FindAsync(account.Id);
            if (existingAccount == null)
            {
                return NotFound("Account not found.");
            }

            _context.Entry(existingAccount).CurrentValues.SetValues(account);
            await _context.SaveChangesAsync();

            return Ok(account);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var account = await _accountService.GetAccountById(id);
            if (account == null)
            {
                return NotFound("Account not found.");
            }

            await _accountService.DeleteAccount(id);
            return Ok("Deleted successfully");
        }
    }
}
