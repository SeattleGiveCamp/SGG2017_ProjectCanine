﻿using ProjectCanine.AdminPortal.Data;
using ProjectCanine.AdminPortal.Services;
using ProjectCanine.AdminPortal.ViewModels;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProjectCanine.AdminPortal.Controllers
{
	public class TestController : Controller
	{
		private readonly ICanineProjDbContext dbContext;
		private readonly ITestServices testServices;

		public TestController(ICanineProjDbContext dbCtx, ITestServices testSvcs)
		{
			dbContext = dbCtx ?? throw new ArgumentNullException(nameof(dbCtx));
			testServices = testSvcs ?? throw new ArgumentNullException(nameof(testSvcs));
		}

		// GET: TestResults
		public async Task<ActionResult> Index()
		{
			var viewModel = testServices.GetTests();

			return View(viewModel);
		}

		// GET: Test/Details/{Guid}
		public ActionResult Details(Guid id)
		{
			if (id == Guid.Empty)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}

			TestGridRow testGridRow = testServices.GetTest(id);

			if (testGridRow == null)
			{
				return HttpNotFound();
			}

			return View(testGridRow);
		}

		// in case Deletion wants to be added to the page.
		//// GET: TestResults/Delete/5
		//public async Task<ActionResult> Delete(Guid? id)
		//{
		//    if (id == null)
		//    {
		//        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
		//    }
		//    TestResult testResult = await dbContext.TestResults.FindAsync(id);
		//    if (testResult == null)
		//    {
		//        return HttpNotFound();
		//    }
		//    return View(testResult);
		//}

		//// POST: TestResults/Delete/5
		//[HttpPost, ActionName("Delete")]
		//[ValidateAntiForgeryToken]
		//public async Task<ActionResult> DeleteConfirmed(Guid id)
		//{
		//    TestResult testResult = await dbContext.TestResults.FindAsync(id);
		//    dbContext.TestResults.Remove(testResult);
		//    await dbContext.SaveChangesAsync();
		//    return RedirectToAction("Index");
		//}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				dbContext.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
