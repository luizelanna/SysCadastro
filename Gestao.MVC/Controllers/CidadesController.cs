using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using Gestao.Application.Interfaces;
using Gestao.Application.ViewModels;
using PagedList;

namespace CadastroDeAlunos.Controllers
{
    [Authorize]
    public class CidadesController : Controller
    {
        //private BdAlunoEntities db = new BdAlunoEntities();
        private readonly ICIdadeAppServicos _cidadeServicos;

        public CidadesController(ICIdadeAppServicos cidadeServicos)
        {
            _cidadeServicos = cidadeServicos;
        }

        // GET: Aluno/Cidades
        public async Task<ActionResult> Index(string sortOrder, string currebtFilter, string searchString, int? page, string coluna)
        {
            Session.RemoveAll();
            ViewBag.CurrentSort = sortOrder;
            ViewBag.CidadeParamentro = String.IsNullOrEmpty(sortOrder) ? "Cidade_desc" : "";
            ViewBag.EstadoParamentro = String.IsNullOrEmpty(sortOrder) ? "Estado_desc" : "";
            ViewBag.CepParamentro = String.IsNullOrEmpty(sortOrder) ? "Cep_desc" : "";

            if (searchString != null)
            {
                page = 1;
            }
            ViewBag.CurrentSort = searchString;

            var cidadeModel = _cidadeServicos.ObterTodos();

            if (!String.IsNullOrEmpty(searchString))
            {
                if (coluna == "id")
                {
                    cidadeModel = cidadeModel.Where(b => b.id == 6);
                }
                else if (coluna == "NomeCidade")
                {
                    cidadeModel = cidadeModel.Where(b => b.NomeCidade.ToUpper().Contains(searchString.ToUpper()));
                }
                else if (coluna == "Estado")
                {
                    cidadeModel = cidadeModel.Where(b => b.Estado.ToUpper().Contains(searchString.ToUpper()));
                }
                else if (coluna == "Cep")
                {
                    cidadeModel = cidadeModel.Where(b => b.Cep.ToUpper().Contains(searchString.ToUpper()));
                }
                else
                {
                    cidadeModel = cidadeModel.Where(b => b.NomeCidade.ToUpper().Contains(searchString.ToUpper()));
                }
            }
            switch (sortOrder)
            {
                case "Cidade_desc":
                    cidadeModel = cidadeModel.OrderBy(b => b.NomeCidade);
                    break;
                case "Estado_desc":
                    cidadeModel = cidadeModel.OrderBy(b => b.Estado);
                    break;
                case "Cep_desc":
                    cidadeModel = cidadeModel.OrderByDescending(b => b.Cep);
                    break;
                default:
                    cidadeModel = cidadeModel.OrderByDescending(b => b.id);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            return View(cidadeModel.ToPagedList(pageNumber, pageSize));
        }

        // GET: Aluno/Cidades/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CidadesViewModel cidades = _cidadeServicos.ObterPorId(id);
            if (cidades == null)
            {
                return HttpNotFound();
            }
            return View(cidades);
        }

        // GET: Aluno/Cidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Cidades/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,NomeCidade,Estado,Cep")] CidadesViewModel cidades)
        {
            if (ModelState.IsValid)
            {
                _cidadeServicos.Adicionar(cidades);
                return RedirectToAction("Index");
            }

            return View(cidades);
        }

        public PartialViewResult CreateCidade()
        {
            CidadesViewModel cidades = new CidadesViewModel();
            return PartialView("CidadePartial", cidades);
        }


        // GET: Aluno/Cidades/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CidadesViewModel cidades = _cidadeServicos.ObterPorId(id);
            if (cidades == null)
            {
                return HttpNotFound();
            }
            return View(cidades);
        }

        // POST: Aluno/Cidades/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,NomeCidade,Estado,Cep")] CidadesViewModel cidades)
        {
            if (ModelState.IsValid)
            {
                _cidadeServicos.Atualizar(cidades);
                return RedirectToAction("Index");
            }
            return View(cidades);
        }

        // GET: Aluno/Cidades/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CidadesViewModel cidades = _cidadeServicos.ObterPorId(id);
            if (cidades == null)
            {
                return HttpNotFound();
            }
            return View(cidades);
        }

        // POST: Aluno/Cidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            _cidadeServicos.Remover(id);
            //CidadesViewModel cidades = await db.CidadesViewModel.FindAsync(id);
            //db.Cidades.Remove(cidades);
            //await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _cidadeServicos.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
