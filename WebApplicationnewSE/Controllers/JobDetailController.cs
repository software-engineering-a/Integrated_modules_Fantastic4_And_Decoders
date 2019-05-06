using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationnewSE.Models;

namespace WebApplicationnewSE.Controllers
{
    public class JobDetailController : Controller
    {
        // GET: JobDetail
        public ActionResult Index()
        {

           

            return View();
        }


        public ActionResult applyforjob() {
            Applyforjob a = new Applyforjob();
            List<String> check = a.CheckForResumeCompletion();
            bool checkk=false;

            foreach(var x in check)
            {
                ResumeCreation3 r = new ResumeCreation3();

                if (r.ResumeStatus == "completed")
                {
                    checkk = true;

                }

                
            }
            if (checkk == true)
            {
                a.update_job_applied(1);
            }

            return View();
        }






    }
}