using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Post_e_Delete.Controllers
{
    public class Delete
    {

        [HttpGet]
        public async Task<IActionResult> Delete(long? id) {

            if (id == null) 
                return NotFound();

            var produto = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produto == null)
                return NotFound();

            return View(Produto);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {

            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
