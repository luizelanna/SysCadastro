using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Gestao.Application.Interfaces;
using Gestao.Application.ViewModels;

namespace CadastroDeAlunos.Controllers
{
    public class TipoPessoasController : Controller
    {
        private readonly ITipoPessoaAppServicos _tipoPessoaServicos;

        public TipoPessoasController(ITipoPessoaAppServicos tipoPessoaServicos)
        {
            _tipoPessoaServicos = tipoPessoaServicos;
        }

        // GET: Aluno/TipoPessoas
        public ActionResult Index()
        {
            return View(_tipoPessoaServicos.ObterTodos());
        }

        // GET: Aluno/TipoPessoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/TipoPessoas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descricao")] TipoPessoasViewModel tipoPessoas)
        {
            if (ModelState.IsValid)
            {
                _tipoPessoaServicos.Adicionar(tipoPessoas);
                return RedirectToAction("Index");
            }

            return View(tipoPessoas);
        }

        // GET: Aluno/TipoPessoas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPessoasViewModel tipoPessoas = _tipoPessoaServicos.ObterPorId(id.Value);
            ;
            if (tipoPessoas == null)
            {
                return HttpNotFound();
            }
            return View(tipoPessoas);
        }

        // POST: Aluno/TipoPessoas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,Descricao")] TipoPessoasViewModel tipoPessoas)
        {
            if (ModelState.IsValid)
            {
                _tipoPessoaServicos.Atualizar(tipoPessoas);
                return RedirectToAction("Index");
            }
            return View(tipoPessoas);
        }

        // GET: Aluno/TipoPessoas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoPessoasViewModel tipoPessoas = _tipoPessoaServicos.ObterPorId(id.Value);
            ;
            if (tipoPessoas == null)
            {
                return HttpNotFound();
            }
            return View(tipoPessoas);
        }

        // POST: Aluno/TipoPessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            _tipoPessoaServicos.Remover(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _tipoPessoaServicos.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
