using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwissWallet.Data;
using SwissWallet.Models.Domain;

namespace SwissWallet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly SwissWalletDbContext _context;

        public AccountsController(SwissWalletDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var accounts = await _context.Accounts.ToListAsync();
            return Ok(accounts);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
                return NotFound();

            return Ok(account);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAccount), new { id = account.Id }, account);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAccount(int id, Account updated)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
                return NotFound();

            account.Name = updated.Name;
            account.Currency = updated.Currency;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
                return NotFound();

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}