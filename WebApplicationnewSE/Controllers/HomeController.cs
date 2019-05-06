using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationnewSE.Models;

namespace WebApplicationnewSE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


           
            return View();

        }

        [HttpPost]
        public ActionResult Findjob()
        {
            string skill = Request["skills"];
            string loc = Request["location"];
            string category = Request["category"];
            SearchJob s = new SearchJob();

            List<String> titles = new List<string>();
            List<String> locations = new List<string>();
            List<int> salaries = new List<int>();
            List<String> starttimes = new List<string>();
            List<String> endtimes = new List<string>();
            List<String> categories = new List<string>();
            List<String> skills = new List<string>();
            List<String> jobtypes = new List<string>();

            List<JobPost> jj = new List<JobPost>();
            //IQueryable result= s.searchRelevantJob(skill, loc, category);

            List<JobPost> a = s.searchRelevantJob(skill, loc, category);
            int i = 0;
            foreach (var x in a) {

                //titles.Clear();
                //skills.Clear();

                JobPost j = new JobPost();
                
                j.Locationn = x.Locationn;
                j.RequiredSkills = x.RequiredSkills;
                j.Designation = x.Designation;
                j.jobTyoe = x.jobTyoe;
                j.Salary = x.Salary;
                j.StartTime = x.StartTime;
                j.EndTime = x.EndTime;
                j.Title = x.Title;
                jj.Add(j);

                //titles.Add(x.Title);
                //locations.Add(x.Locationn);
                //skills.Add(x.RequiredSkills);
                //jobtypes.Add(x.jobTyoe);
                //starttimes.Add(x.StartTime);
                //endtimes.Add(x.EndTime);
                //categories.Add(x.Department);

                //ViewBag[i].location = x.Locationn;
                //ViewBag[i].skills = x.RequiredSkills;
                //ViewBag[i].category = x.Department;
                //ViewBag[i].starttime = x.StartTime;
                //ViewBag[i].endtime = x.EndTime;
                //ViewBag[i].titleee= x.Title;
                //ViewBag[i].salary= x.Salary;
                //ViewBag[i].jobtype= x.jobTyoe;
                ViewBag.jobs = jj;
            }
            //ViewBag.nameee = s.showjob();
            //ViewBag.nameee = result;
            //var x = result;
            //int id = 00;
           // foreach (dynamic a in x)
            //{
              //   id = a.id;
           // }
           // ViewBag.nam = id;

            return View("Indexx3");
        }

    }
}